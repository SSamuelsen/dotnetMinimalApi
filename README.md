A Simple .Net 6 Minimal API Testing Environment to learn minimal APIs

- my goal with this is to create an easy to use, clean template for implementing Apis in the future. I want to be able to pull this project down and click F5 and run this with no additional machine setup.

Current State:
- basic GET routing setup
- SwaggerUI setup
- Dependency Injection
- Service Layer
- Data Access Layer (Entity - DTO pattern)

TODO:
- logging
- authentication with JWT
- Authorize with roles
- CORS setup
- wire up endpoints to connect to my minimalreact React frontend
- unit/integration testing
- connect to MySQL db (use Dapper)
- setup configuration files
- setup globalization using Resource files

Coding goals for this project:
- keep it minimal (write as little code as possible)
- maintain clear separation between Development env and Production env in code
- zero business logic in program.cs file
- zero nested if statements
- complete interface driven design
- zero code warnings
