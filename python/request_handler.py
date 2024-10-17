# request_handler.py
import requests

class RequestHandler:
    def __init__(self, base_url):
        self.base_url = base_url
    
    def make_request(self, path="", method="GET", headers=None, params=None, data=None):
        """Generic function to make HTTP requests."""
        url = f"{self.base_url}/{path}".strip("/")
        try:
            response = requests.request(
                method=method,
                url=url,
                headers=headers,
                params=params,
                data=data,
                timeout=10
            )
            return response
        except requests.RequestException as e:
            print(f"Error with request to {url}: {e}")
            return None
    
    def get(self, path="", headers=None, params=None):
        """Send a GET request."""
        return self.make_request(path=path, method="GET", headers=headers, params=params)

    def post(self, path="", headers=None, data=None):
        """Send a POST request."""
        return self.make_request(path=path, method="POST", headers=headers, data=data)
