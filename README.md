# ApiWorkflow
## API 
Rest/MediaR

## Database
Local sqlserver instance with entityFrameworkCore
Command lines 
for generating init migrations
```sh
cd src
dotnet ef migrations add InitialCreate --project ApiWorkflow.Infrastructure --startup-project ApiWorkflow
```
Add more tables change
```sh
dotnet ef migrations add AddAccountAndTransaction --project ApiWorkflow.Infrastructure --startup-project ApiWorkflow
```
To check if db script is fine with DBA
```sh
dotnet ef migrations script --project ApiWorkflow.Infrastructure --startup-project ApiWorkflow
```
Apply migrations to database via command lines
```sh
dotnet ef database update --project ApiWorkflow.Infrastructure --startup-project ApiWorkflow
```

## CI/CD
Actions

## Fake Requirement
- System allows for users and user accounts.
- A user can have as many accounts as they want.
- A user can create and delete accounts.
- A user can deposit and withdraw from accounts.
- An account cannot have less than $100 at any time in an account.
- A user cannot withdraw more than 90% of their total balance from an account in a single transaction.
- A user cannot deposit more than $10,000 in a single transaction.

