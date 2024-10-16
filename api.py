# api.py
class Api:
    def __init__(self, name: str, base_url: str):
        self.name = name
        self.base_url = base_url

    def __repr__(self):
        return f"API(name={self.name}, base_url={self.base_url})"
