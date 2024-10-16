# website.py
from endpoint import Endpoint
from api import Api

class Website:
    def __init__(self, domain: str):
        self.domain = domain
        self.roots = []  # List of Root objects
        self.endpoints = []  # List of Endpoint objects
        self.vulnerabilities = []  # List of Vulnerability objects
        self.apis = []  # List of Api objects

    def add_endpoint(self, endpoint: Endpoint):
        self.endpoints.append(endpoint)

    def add_api(self, api: Api):
        self.apis.append(api)

    def scan_for_vulnerabilities(self):
        """Scans the website for vulnerabilities across all endpoints."""
        for endpoint in self.endpoints:
            print(f"Scanning {endpoint.url} for vulnerabilities...")  # Print the endpoint being scanned

            # Scanning for SQL Injection
            sql_vulns = endpoint.scan_for_sql_injection()
            if sql_vulns:
                print(f"Found SQL Injection vulnerabilities at {endpoint.url}")

            # Scanning for XSS
            xss_vulns = endpoint.scan_for_xss()
            if xss_vulns:
                print(f"Found XSS vulnerabilities at {endpoint.url}")

            # Scanning for CSRF
            csrf_vulns = endpoint.scan_for_csrf()
            if csrf_vulns:
                print(f"Found CSRF vulnerabilities at {endpoint.url}")

            # Scanning for Open Redirects
            open_redirect_vulns = endpoint.scan_for_open_redirects()
            if open_redirect_vulns:
                print(f"Found Open Redirect vulnerabilities at {endpoint.url}")

            # Scanning for Sensitive Data Exposure
            sensitive_data_vulns = endpoint.scan_for_sensitive_data_exposure()
            if sensitive_data_vulns:
                print(f"Found Sensitive Data Exposure vulnerabilities at {endpoint.url}")

    def report_vulnerabilities(self):
        """Prints a summary of all vulnerabilities found."""
        if not self.vulnerabilities:
            print("No vulnerabilities found.")
        else:
            print("\n--- Vulnerabilities Found ---")
            for vuln in self.vulnerabilities:
                print(f"[{vuln['vuln_type']}] {vuln['description']} (Severity: {vuln['severity']})")
