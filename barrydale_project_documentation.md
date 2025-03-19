# Barrydale Tourism App - Technical Documentation

## Project Overview
The Barrydale Tourism App is a web application built using Blazor WebAssembly with ASP.NET Core, designed to provide tourism information and business management for the town of Barrydale, South Africa. The application follows a subscription-based model where businesses can register and manage their presence on the platform.

## Tech Stack

### Framework and Language
- **Framework**: .NET 8.0
- **UI Framework**: Blazor WebAssembly with Interactive Server Components
- **Programming Language**: C# 12
- **Authentication**: ASP.NET Core Identity with Individual Accounts
- **Database**: SQL Server with Entity Framework Core 8.0
- **Architecture**: Hybrid client/server approach with WebAssembly and server components

### Key Libraries and Packages
- **Microsoft.AspNetCore.Components.WebAssembly** v8.0.13
- **Microsoft.AspNetCore.Components.WebAssembly.Server** v8.0.13
- **Microsoft.AspNetCore.Components.WebAssembly.Authentication** v8.0.13
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore** v8.0.13
- **Microsoft.EntityFrameworkCore.SqlServer** v8.0.13
- **Microsoft.EntityFrameworkCore.Tools** v8.0.13

## Project Structure

### Solution Structure
- **Barrydale.sln**: The main solution file containing both projects
- **Barrydale/**: Server-side project (ASP.NET Core)
- **Barrydale.Client/**: Client-side project (Blazor WebAssembly)

### Server Project (Barrydale)

#### Key Components
- **Program.cs**: Application entry point and service configuration
- **Data/**: Contains data models and Entity Framework contexts
  - **ApplicationDbContext.cs**: EF Core database context
  - **ApplicationUser.cs**: Identity user model
  - **Migrations/**: Database migration files
- **Models/**: Business domain models
  - **Business.cs**: Base business model
  - **Specialized business types**: Restaurant, Accommodation, Shop, etc.
  - **Supporting models**: Reviews, Events, BusinessHours, etc.
- **Components/**: Server-side Blazor components
  - **App.razor**: Root application component
  - **Routes.razor**: Application routing configuration
  - **Pages/**: Page components
  - **Layout/**: Layout components
  - **Account/**: Authentication and user management components

#### Configuration
- **appsettings.json**: Application configuration including connection strings
- **appsettings.Development.json**: Development-specific configuration

### Client Project (Barrydale.Client)

#### Key Components
- **Program.cs**: Client application entry point
- **_Imports.razor**: Global Razor imports
- **PersistentAuthenticationStateProvider.cs**: Authentication state provider
- **UserInfo.cs**: User information model
- **RedirectToLogin.razor**: Component for authentication redirects

## Authentication and Security

### Authentication Flow
The application uses ASP.NET Core Identity with individual user accounts, allowing:
- User registration with email confirmation
- Secure login with cookie authentication
- Role-based authorization
- Account management (password reset, email changes, etc.)

### Security Features
- **HTTPS**: Enforced with HSTS headers
- **Anti-forgery**: Automatically enabled for forms
- **Password Policy**: ASP.NET Identity default password requirements
- **Account Confirmation**: Email confirmation required
- **Cookie Authentication**: Secure authentication cookies

## Database Architecture

### Entity Framework Setup
- **Connection String**: LocalDB SQL Server for development
- **Migrations**: Code-first approach with EF Core migrations
- **Identity Schema**: Standard ASP.NET Core Identity tables

### Data Models

#### Business Models
The application uses a Table-per-Hierarchy (TPH) inheritance pattern to handle different types of businesses:

##### Base Business Model
- **Business**: Core entity with common properties for all business types:
  - Basic information (name, description, contact details)
  - Location data (address, coordinates)
  - Metadata (created date, active status)
  - BusinessType discriminator field

##### Specialized Business Types
- **Restaurant**:
  - Cuisine information
  - Reservation capabilities
  - Price range indicators
  - Special diet accommodations
  - Meal types served

- **Accommodation**:
  - Room and guest capacity
  - Amenities (WiFi, parking, pool)
  - Property type and details
  - Pricing information
  - Check-in instructions

- **Shop**:
  - Product types and brands
  - Online store capabilities
  - Delivery information
  - Payment methods

- **TourService**:
  - Tour types and duration
  - Group sizes and pricing
  - Tour highlights and inclusions
  - Meeting point information

- **Attraction**:
  - Attraction type and features
  - Accessibility information
  - Visit duration recommendations
  - Admission details

##### Supporting Models
- **ApplicationUser**: Extended identity user with profile details
- **BusinessImage**: Images for business listings
- **BusinessHours**: Operating hours by day of week
- **Subscription**: Payment and subscription details
- **Event**: Tourism events information
- **Review**: Customer reviews and ratings

### Inheritance Strategy
The application uses Entity Framework Core's Table-per-Hierarchy (TPH) pattern:
- All business types stored in a single `Businesses` table
- `BusinessType` field used as discriminator
- EF Core handles mapping to appropriate derived classes
- Maintains database simplicity while providing type-specific properties

## Client-Side Architecture

### Rendering Modes
The application uses a hybrid rendering approach:
- **Interactive WebAssembly**: Primary rendering mode for client interactivity
- **Server-Side Support**: Available for components requiring server resources

### WebAssembly Integration
- Client-side code compiled to WebAssembly
- Authentication state synchronized between server and client
- Secure communication with the server API endpoints

## Development Environment

### Requirements
- **.NET SDK**: 8.0 or higher
- **IDE**: Visual Studio 2022 or equivalent
- **Database**: SQL Server LocalDB (development)

### Running the Application
1. Ensure .NET 8 SDK is installed
2. Clone the repository
3. Run database migrations: `dotnet ef database update`
4. Start the application: `dotnet run`

## Deployment Considerations

### Hosting Options
- **Azure App Service**: Recommended for production hosting
- **Azure SQL Database**: For the production database
- **Azure CDN**: For static assets distribution

### Configuration for Production
- Update connection strings for production database
- Configure email provider for authentication emails
- Set up proper HTTPS certificates
- Configure proper authentication settings

## Next Steps for Development

### Immediate Tasks
1. Implement user interfaces for different business types
2. Create business registration workflows
3. Implement subscription management with payment integration
4. Design and develop the public-facing tourism information pages

### Future Enhancements
1. Mobile app integration with Ionic/Capacitor
2. Offline capabilities for tourists with limited connectivity
3. Integration with South African payment providers (PayFast recommended)
4. Multi-language support for international tourists 