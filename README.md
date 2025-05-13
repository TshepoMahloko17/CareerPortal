# Blazor Developer Technical Assessment

## Overview

This is a Blazor WebAssembly application developed for a technical assessment. The objective was to replicate a job listings screen based on a provided Figma design and integrate it with a Jobs API.

---

## Setup Instructions

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later
- Visual Studio 2022+ or VS Code with C# support

## Challenges Faced & How I Solved Them
1. API Returned Empty JSON

    The provided API endpoint returned an empty JSON array ([]) during development.

    Verified this behavior using Postman and direct browser requests.

    To proceed with development and UI testing, I created a simulated data source that mimicked the structure of the expected API response.

    This mock data allowed me to validate layout, data binding, and component behavior in the absence of live data.

    The application is built in a way that switching between the real API and simulated data is easy if the API becomes functional later.

### How to Run

1. **Clone the repository**:
   ```bash
