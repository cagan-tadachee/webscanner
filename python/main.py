# main.py
from website import Website
from crawler import Crawler

def main():
    # Input: Website domain
    domain = "https://www.hackthissite.org"  # Ensure no trailing slash
    
    # Create the crawler object
    crawler = Crawler(domain)

    # Discover endpoints and APIs by crawling the domain
    endpoints, apis = crawler.discover_and_bind()

    # Create a website object
    website = Website(domain=domain)

   
    
    for api in apis:
        website.add_api(api)

    # Run vulnerability scans
    print(f"Scanning {domain} for vulnerabilities...")
    website.scan_for_vulnerabilities()

    # Report vulnerabilities found
    website.report_vulnerabilities()

if __name__ == "__main__":
    main()
