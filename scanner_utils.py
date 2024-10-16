# scanner_utils.py

def scan_sql_injection(url: str):
    """Simulated function to check for SQL Injection vulnerabilities."""
    vulnerabilities = []
    if "id=" in url:  # Simulated SQL injection pattern
        vulnerabilities.append({
            'vuln_type': 'SQL Injection',
            'description': f'Potential SQL Injection vulnerability found at {url}',
            'severity': 'High'
        })
    return vulnerabilities


def scan_xss(url: str):
    """Simulated function to check for XSS vulnerabilities."""
    vulnerabilities = []
    if "<script>" in url:  # Simulated XSS pattern
        vulnerabilities.append({
            'vuln_type': 'XSS',
            'description': f'Potential XSS vulnerability found at {url}',
            'severity': 'Medium'
        })
    return vulnerabilities


def scan_open_redirects(url: str):
    """Simulated function to check for open redirect vulnerabilities."""
    vulnerabilities = []
    if "redirect=" in url:  # Simulated open redirect pattern
        vulnerabilities.append({
            'vuln_type': 'Open Redirect',
            'description': f'Potential Open Redirect vulnerability found at {url}',
            'severity': 'Medium'
        })
    return vulnerabilities


def scan_csrf(url: str):
    """Simulated function to check for CSRF vulnerabilities."""
    vulnerabilities = []
    if "csrf_token" not in url:  # Simulated CSRF token absence pattern
        vulnerabilities.append({
            'vuln_type': 'CSRF',
            'description': f'No CSRF token found in {url}',
            'severity': 'High'
        })
    return vulnerabilities


def scan_sensitive_data_exposure(url: str):
    """Simulated function to check for sensitive data exposure."""
    vulnerabilities = []
    if "key=" in url or "password=" in url:  # Simulated sensitive data exposure pattern
        vulnerabilities.append({
            'vuln_type': 'Sensitive Data Exposure',
            'description': f'Sensitive data (e.g., API key, password) found in {url}',
            'severity': 'Critical'
        })
    return vulnerabilities


def scan_insecure_cookies(headers: dict):
    """Simulated function to check for insecure cookies."""
    vulnerabilities = []
    cookies = headers.get('Set-Cookie', '')
    
    if 'HttpOnly' not in cookies or 'Secure' not in cookies:
        vulnerabilities.append({
            'vuln_type': 'Insecure Cookies',
            'description': 'Cookies missing HttpOnly or Secure flags',
            'severity': 'High'
        })
    return vulnerabilities


def scan_directory_traversal(url: str):
    """Simulated function to check for directory traversal vulnerabilities."""
    vulnerabilities = []
    if "../" in url:  # Simulated directory traversal pattern
        vulnerabilities.append({
            'vuln_type': 'Directory Traversal',
            'description': f'Potential Directory Traversal vulnerability found at {url}',
            'severity': 'High'
        })
    return vulnerabilities
