# Blazor WebAssembly Development Guide

## Core Concepts & Complexities

### Routing System

#### How It Works
- **Route Registration**: Defined in `App.razor` with `<Router>` component
- **Route Configuration**: Set via `@page` directives at the top of each component
- **Parameter Binding**: Route parameters defined with curly braces e.g., `@page "/product/{id}"`
- **Route Constraints**: Apply type constraints like `@page "/product/{id:int}"`

#### Key Considerations
- **No Server Involvement**: Routing happens entirely on the client without server requests
- **Case Sensitivity**: Routes are case-sensitive by default
- **Navigation Manager**: Use `NavigationManager` service for programmatic navigation
- **Route Fallback**: Configure 404 handling with `<NotFound>` component in `App.razor`

#### Best Practices
- **Route Structure**: Organize routes hierarchically to reflect application structure
- **Shared Layouts**: Use nested layouts rather than duplicating layout code
- **Consistent Naming**: Follow a consistent pattern for route names
- **Route Guards**: Implement auth guards via the `AuthorizeRouteView` component

### Page Lifecycle & Loading

#### Initial Load Considerations
- **Large Download**: Initial WebAssembly download can be 5-10MB without optimization
- **Startup Time**: First load requires downloading the .NET runtime in WebAssembly format
- **Loading Experience**: Use loading indicators to improve perceived performance

#### Lazy Loading
- **Assembly Lazy Loading**: Load component libraries on demand with:
  ```csharp
  <Router AppAssembly="@typeof(App).Assembly">
      <Found Context="routeData">
          <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
      </Found>
      <NotFound>
          <PageTitle>Not found</PageTitle>
          <LayoutView Layout="@typeof(MainLayout)">
              <p>Sorry, there's nothing at this address.</p>
          </LayoutView>
      </NotFound>
  </Router>
  ```
- **Router.OnNavigateAsync**: Pre-load assemblies before navigation completes
- **LazyAssemblyLoader**: Use built-in service to load assemblies on demand

#### State Preservation
- **Browser Navigation**: Component state is lost during browser navigation by default
- **State Persistence**: Use `PersistentComponentState` to preserve state during page refreshes
- **Serialization**: Ensure state objects are serializable when using persistence

### Performance Optimization

#### Rendering Performance
- **Virtualization**: Use `Virtualize` component for long lists
- **Render Fragments**: Split complex UIs into smaller render fragments
- **Memo Pattern**: Implement `ShouldRender()` to prevent unnecessary renders
- **Component Granularity**: Balance between too many small components and monolithic components

#### Network Considerations
- **Assembly Trimming**: Enable in .csproj to reduce download size
  ```xml
  <PropertyGroup>
    <PublishTrimmed>true</PublishTrimmed>
  </PropertyGroup>
  ```
- **Compression**: Ensure WebAssembly files are served with Brotli/gzip compression
- **Progressive Web App**: Configure as PWA for offline capabilities and caching
- **API Batch Requests**: Bundle multiple API requests to reduce HTTP overhead

#### Memory Management
- **Disposal**: Implement `IDisposable` for components that subscribe to events
- **JS Interop**: Dispose of JS references with `IJSObjectReference.DisposeAsync()`
- **Event Handlers**: Unsubscribe from events in `Dispose()` method
- **Circular References**: Avoid circular references that can cause memory leaks

## Architectural Best Practices

### Component Design

#### Component Hierarchy
- **Layout Components**: For page structure (headers, sidebars, etc.)
- **Container Components**: Manage state and data access
- **Presentation Components**: Display data and emit events
- **Shared Components**: Reusable UI elements like buttons, inputs, etc.

#### Component Communication
- **Parameters**: Pass data down the component tree with parameters
- **Cascading Values**: Share data across many components without explicit parameters
- **Event Callbacks**: Use `EventCallback<T>` for child-to-parent communication
- **State Containers**: Use state containers for complex cross-component state

#### Code Organization
```
/Pages             - Top-level routable pages 
/Components        - Shared components
  /Layout          - Layout components
  /Forms           - Form-related components
  /Data            - Data display components
/Services          - Application services
/Models            - Data models
/Shared            - Utilities and helpers
```

### State Management

#### Local Component State
- **Private Fields**: For state exclusive to a component
- **Stateful Service DI**: For shared state with limited scope

#### Application State
- **Dependency Injection**: Services registered with appropriate lifetimes
- **Flux Pattern**: State containers with actions and reducers
- **Blazor State Management Libraries**: Fluxor, Blazor-State, etc.

#### State Persistence Strategies
- **Browser Storage**: LocalStorage/SessionStorage for client-side persistence
- **Server Storage**: Store state on server via API calls
- **PersistentComponentState**: For preserving state during page refreshes

### JavaScript Interop

#### Working with JS Libraries
- **IJSRuntime Service**: Primary way to invoke JavaScript from C#
- **JavaScript Isolation**: Use JS modules for encapsulation
- **Static Imports**: Define static imports in `index.html` or as modules
- **Object References**: Pass JS object references between C# and JS

#### Best Practices
- **Minimize Interop Calls**: Each call has performance overhead
- **Batch Operations**: Group multiple JS operations in a single interop call
- **Type Safety**: Use TypeScript definitions and C# wrappers
- **Lazy Loading**: Load JS libraries only when needed

## Common Challenges & Solutions

### Authentication & Authorization

#### Authentication Options
- **IdentityServer**: Complete authentication solution
- **Auth0/Okta**: Third-party identity providers
- **Azure AD B2C**: Microsoft's identity service
- **Cookie Authentication**: For traditional browser-based auth

#### Implementation Patterns
- **Auth State Provider**: Extend `AuthenticationStateProvider`
- **Token Storage**: Store tokens in browser storage with security measures
- **Auth Interceptors**: Attach tokens to outgoing HTTP requests
- **Silent Refresh**: Implement token refresh without user interaction

### Form Handling

#### Form Validation
- **Data Annotations**: Use attributes like `[Required]`, `[StringLength]`
- **EditForm**: Use `<EditForm>` component with `DataAnnotationsValidator`
- **Custom Validators**: Implement `ValidationAttribute` for custom rules
- **Server Validation**: Handle server-side validation errors gracefully

#### Advanced Form Scenarios
- **Dynamic Forms**: Generate forms based on metadata
- **Multi-step Forms**: Implement wizard-like forms with state management
- **Form Arrays**: Handle collections of form items
- **Form State**: Manage dirty/pristine state for save button enablement

### SEO & Server-Side Rendering

#### SEO Limitations
- **Client Rendering**: Content not fully available to search engine crawlers
- **Solutions**:
  - Implement server-side prerendering
  - Consider Blazor Server for content-heavy sites
  - Use static generation for public pages

#### Hybrid Approaches
- **Static Pages + WebAssembly**: Pre-render static content, hydrate with Blazor
- **SEO-Critical Pages**: Use server rendering for public-facing pages
- **Progressive Enhancement**: Start with HTML, enhance with WebAssembly

## Deployment & Hosting

### Deployment Options

#### Static Hosting
- **Azure Static Web Apps**: Supports Blazor WebAssembly natively
- **GitHub Pages/Netlify**: With appropriate URL rewrite rules
- **CDN Distribution**: Deploy behind CDN for performance

#### Configuration
- **base href**: Set correct base path in `index.html`
- **URL Rewriting**: Configure server to route all requests to `index.html`
- **Cache Headers**: Set appropriate cache headers for static assets
- **Environment Variables**: Manage using `wwwroot/appsettings.json`

### CI/CD Pipeline

#### Build Process
- **PublishSingleFile**: Package as a single deployable file
- **AOT Compilation**: Consider ahead-of-time compilation for performance
- **Progressive Web App**: Configure service worker and manifest

#### Testing Strategy
- **Unit Testing**: Use bUnit for component testing
- **E2E Testing**: Playwright/Selenium for integration testing
- **Visual Testing**: Snapshot testing for UI consistency

## Application Patterns

### Offline-First Approach

#### Implementation
- **Service Workers**: Register for offline capabilities
- **IndexedDB**: Store data locally for offline access
- **Synchronization**: Implement sync when connection restored
- **Conflict Resolution**: Strategy for handling offline changes

#### User Experience
- **Connection Status**: Indicate online/offline status to users
- **Queueing Operations**: Allow operations to be performed offline
- **Graceful Degradation**: Maintain core functionality without connection

### Real-Time Updates

#### SignalR Integration
- **Hub Connection**: Establish connection in a service
- **Lifecycle Management**: Reconnect during network issues
- **Message Handling**: Dispatch received messages to state management

#### Considerations
- **Connection State**: Handle disconnected state gracefully
- **Reconnection Logic**: Implement exponential backoff
- **Message Buffering**: Queue messages during disconnection

## Performance Checklist

### Development Phase
- [ ] Implement lazy loading for routes and libraries
- [ ] Use virtualization for long lists
- [ ] Implement proper component disposal
- [ ] Minimize JavaScript interop calls
- [ ] Use server prerendering for initial load performance

### Build Phase
- [ ] Enable IL trimming/linking
- [ ] Configure effective caching strategy
- [ ] Implement code splitting
- [ ] Minify CSS/JS resources
- [ ] Enable Brotli compression

### Deployment Phase
- [ ] Deploy on CDN or edge network
- [ ] Set up monitoring and performance tracking
- [ ] Configure proper cache headers
- [ ] Implement progressive loading indicators
- [ ] Test on various network conditions

## Resources & References

- [Official Blazor Documentation](https://docs.microsoft.com/aspnet/core/blazor/)
- [Blazor WebAssembly Performance Best Practices](https://learn.microsoft.com/aspnet/core/blazor/webassembly-performance-best-practices)
- [ASP.NET Core Blazor Advanced Scenarios](https://learn.microsoft.com/aspnet/core/blazor/advanced-scenarios)
- [Microsoft Learn - Blazor Path](https://learn.microsoft.com/training/paths/build-web-apps-with-blazor/) 