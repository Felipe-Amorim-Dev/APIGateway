# APIGateway — ASP.NET Core + YARP

**Educational prototype — NOT production-ready.** This repository demonstrates a .NET 8 reverse proxy using YARP, JWT bearer validation and route protection. It has not undergone a production security review.

## Security remediation
- Hard-coded demonstration credentials have been replaced (in the remediation branch) with optional local configuration keys `DemoAuth:Username` and `DemoAuth:Password`. **Do not use this demo endpoint in production.** Replace it with an identity provider and hardened authentication before real use.
- Set `Jwt:Key` via environment variable `Jwt__Key` or .NET user-secrets; use a random key with at least 32 UTF-8 bytes. No real secret belongs in `appsettings.json`.
- Previously published JWT keys must be rotated if they were used for any actual environment. Removing the current value does not remove Git history.
- Example configurations should only point to local or dedicated test services.

## Architecture
- `APIGateWay.API/Program.cs`: authentication, DI, YARP pipeline
- `APIGateWay.API/Controllers/AuthController.cs`: demonstration-only token endpoint
- `APIGateWay.API/Services`: JWT generation logic
- `APIGateWay.API/appsettings.json`: route/cluster settings and non-secret JWT metadata

## Development
```bash
dotnet restore APIGateWay.sln
dotnet build APIGateWay.sln
dotnet user-secrets set "Jwt:Key" "<generate-your-own-random-key>" --project APIGateWay.API
dotnet run --project APIGateWay.API
```
The user-secrets command requires an initialized secrets ID in that project; alternatively set `Jwt__Key` in your shell. Example commands contain placeholders, not deployable secrets.

The YARP destination addresses are local examples; update them to match the services you control. Running this project does not validate downstream authentication or operational security.

**PT-BR:** Gateway didático em .NET e YARP. Credenciais fixas e chave JWT publicada foram identificadas na auditoria. A remediação move a configuração sensível para o ambiente, mas **não** transforma a autenticação de demonstração em uma solução pronta para produção.
