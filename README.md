# Barrydale Tourism App

A subscription-based tourism platform for Barrydale, South Africa, built with Blazor WebAssembly and ASP.NET Core.

## Overview

This application is designed to help tourists discover Barrydale while allowing local businesses to maintain their online presence through a subscription model. The platform provides features for business listings, event management, and tourist information.

## Features

- Business registration and subscription management
- Interactive map of Barrydale attractions
- Event calendar and listings
- Detailed business profiles
- Mobile-responsive design
- Secure payment processing

## Technology Stack

- ASP.NET Core 8.0
- Blazor WebAssembly with Interactive Server Components
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- SQL Server (LocalDB sufficient for development)
- Visual Studio 2022 or other compatible IDE

### Setup and Installation

1. Clone the repository
   ```
   git clone https://github.com/yourusername/Barrydale.git
   ```

2. Navigate to the project directory
   ```
   cd Barrydale
   ```

3. Restore dependencies
   ```
   dotnet restore
   ```

4. Update the database
   ```
   dotnet ef database update
   ```

5. Run the application
   ```
   dotnet run
   ```

## Project Structure

- **Barrydale** - Main server-side project (ASP.NET Core)
- **Barrydale.Client** - Client-side project (Blazor WebAssembly)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- The town of Barrydale for inspiration
- All contributors to this project 