import pandas as pd
from collections import defaultdict

class ReportFormatter:
    @staticmethod
    def display_website_info(website):
        """Display the overall structure and information about the website."""
        print(f"\n--- Website Report: {website.domain} ---")
        print(f"Total Endpoints Discovered: {len(website.endpoints)}")
        print(f"Total APIs Discovered: {len(website.apis)}")
        print(f"Total Vulnerabilities Detected: {len(website.vulnerabilities)}\n")
    
    @staticmethod
    def display_endpoints(endpoints):
        """Display information about discovered endpoints."""
        if not endpoints:
            print("No endpoints discovered.")
        else:
            print("\n--- Discovered Endpoints ---")
            for i, endpoint in enumerate(endpoints, 1):
                print(f"[{i}] Endpoint URL: {endpoint.url}")
    
    @staticmethod
    def display_apis(apis):
        """Display information about discovered APIs."""
        if not apis:
            print("\nNo APIs discovered.")
        else:
            print("\n--- Discovered APIs ---")
            for i, api in enumerate(apis, 1):
                print(f"[{i}] API Name: {api.name}, Base URL: {api.base_url}")

    @staticmethod
    def classify_vulnerabilities(vulnerabilities):
        """Classify vulnerabilities by type and return a grouped dictionary."""
        classified_vulns = defaultdict(list)
        for vuln in vulnerabilities:
            classified_vulns[vuln['vuln_type']].append(vuln)
        return classified_vulns
    
    @staticmethod
    def display_vulnerabilities(vulnerabilities):
        """Display discovered vulnerabilities grouped by type in a formatted way."""
        if not vulnerabilities:
            print("\nNo vulnerabilities found.")
            return

        # Group vulnerabilities by type
        classified_vulns = ReportFormatter.classify_vulnerabilities(vulnerabilities)
        
        print("\n--- Discovered Vulnerabilities ---")
        for vuln_type, vulns in classified_vulns.items():
            print(f"\nVulnerability Type: {vuln_type} (Total: {len(vulns)})")
            for i, vuln in enumerate(vulns, 1):
                print(f"  [{i}] Description: {vuln['description']}")
                print(f"      Severity: {vuln['severity']}")
    
    @staticmethod
    def export_to_excel(website, file_name="website_security_report.xlsx"):
        """Export the extracted data to an Excel file."""
        # Create a Pandas Excel writer using OpenPyXL as the engine
        with pd.ExcelWriter(file_name, engine='openpyxl') as writer:
            # Export Endpoints
            if website.endpoints:
                endpoints_data = {
                    "Endpoint URL": [endpoint.url for endpoint in website.endpoints],
                }
                endpoints_df = pd.DataFrame(endpoints_data)
                endpoints_df.to_excel(writer, sheet_name='Endpoints', index=False)
            
            # Export APIs
            if website.apis:
                apis_data = {
                    "API Name": [api.name for api in website.apis],
                    "Base URL": [api.base_url for api in website.apis],
                }
                apis_df = pd.DataFrame(apis_data)
                apis_df.to_excel(writer, sheet_name='APIs', index=False)
            
            # Export Vulnerabilities
            if website.vulnerabilities:
                vulnerabilities_data = {
                    "Vulnerability Type": [vuln['vuln_type'] for vuln in website.vulnerabilities],
                    "Description": [vuln['description'] for vuln in website.vulnerabilities],
                    "Severity": [vuln['severity'] for vuln in website.vulnerabilities],
                }
                vulnerabilities_df = pd.DataFrame(vulnerabilities_data)
                vulnerabilities_df.to_excel(writer, sheet_name='Vulnerabilities', index=False)

        print(f"\nData exported to {file_name} successfully!")
