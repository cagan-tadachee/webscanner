# crawler.py
import re
from bs4 import BeautifulSoup
from request_handler import RequestHandler
from endpoint import Endpoint
from api import Api

class Crawler:
    def __init__(self, domain):
        self.handler = RequestHandler(domain)
        self.domain = domain
        self.endpoints = []
        self.apis = []

    def discover_endpoints(self):
        """Discover endpoints by crawling the website."""
        # Start with the root URL
        response = self.handler.get("")
        if response and response.status_code == 200:
            self._parse_html(response.text)

    def _parse_html(self, html):
        """Parse HTML to find forms, links, and potential endpoints."""
        soup = BeautifulSoup(html, 'html.parser')
        
        # Extract href links
        for link in soup.find_all('a', href=True):
            url = link['href']
            if self._is_valid_url(url):
                self.endpoints.append(Endpoint(url=url))
        
        # Extract form actions
        for form in soup.find_all('form', action=True):
            action = form['action']
            if self._is_valid_url(action):
                self.endpoints.append(Endpoint(url=action))

    def _is_valid_url(self, url):
        """Helper to check if a URL is valid."""
        # Ensure the URL belongs to the same domain or is a relative path
        return url.startswith(self.domain) or url.startswith('/')

    def discover_apis(self):
        """Attempt to discover API endpoints by guessing common paths."""
        common_api_paths = ["/api", "/v1", "/v2", "/graphql", "/rest"]
        for path in common_api_paths:
            response = self.handler.get(path)
            if response and response.status_code == 200:
                self.apis.append(Api(name=f"API for {path}", base_url=f"{self.domain}{path}"))
    
    def discover_and_bind(self):
        """Automatically discover endpoints and APIs, then bind them."""
        self.discover_endpoints()
        self.discover_apis()
        return self.endpoints, self.apis
