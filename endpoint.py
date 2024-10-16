import requests 
class Endpoint:
    
    def __init__(self, url: str):
        if not url.startswith('http'):
            if url.startswith('/'):  # If it starts with a slash, append to the base domain
                self.url = f"https://www.hackthissite.org{url}"  # You may want to change this based on your actual base domain
            else:
                self.url = f"https://{url}"  # Default to HTTPS if missing
        else:
            self.url = url

        # Check if the URL is valid (optional, you can use regex for more complex validation)
        if not self.is_valid_url(self.url):
            print(f"Warning: Invalid URL '{self.url}' detected.")

    @staticmethod
    def is_valid_url(url: str) -> bool:
        # Simple validation logic (you can make this more complex)
        return url.startswith('http://') or url.startswith('https://')

  
    def scan_for_sql_injection(self):
        """Simulates SQL Injection checks."""
        payloads = ["' OR '1'='1", "'; DROP TABLE users; --"]
        vulnerabilities = []

        for payload in payloads:
            try:
                # Ensure the request URL is absolute
                response = requests.get(self.url, params={'input': payload})
                if "error" in response.text.lower():  # This check can be adjusted based on actual error messages
                    vulnerabilities.append({
                        'vuln_type': 'SQL Injection',
                        'description': f'SQL Injection vulnerability found at {self.url} with payload: {payload}',
                        'severity': 'Critical'
                    })
            except requests.exceptions.RequestException as e:
                print(f"Request failed for URL: {self.url} with payload: {payload}. Error: {e}")

        if vulnerabilities:
            print(f"SQL Injection vulnerabilities detected at {self.url}.")
        return vulnerabilities

    def scan_for_xss(self):
        """Simulates XSS checks."""
        payloads = ['<script>alert("XSS")</script>', '" onmouseover="alert(1)']
        vulnerabilities = []

        for payload in payloads:
            try:
                response = requests.get(self.url, params={'input': payload})
                if payload in response.text:
                    vulnerabilities.append({
                        'vuln_type': 'XSS',
                        'description': f'XSS vulnerability found at {self.url} with payload: {payload}',
                        'severity': 'Medium'
                    })
            except requests.exceptions.RequestException as e:
                print(f"Request failed for URL: {self.url} with payload: {payload}. Error: {e}")

        if vulnerabilities:
            print(f"XSS vulnerabilities detected at {self.url}.")
        return vulnerabilities

    # ... (Include similar updates for the other scanning methods) ...
