Para tirar usuario e senha do appsettings da sua api, você deve usar o User-Secrets para criar o arquivo, 
mas ainda não esta configurado.

comando:
dotnet user-secrets init --project \ProjetoAPI.csproj


após utilizar o comando para criar o secrets o comando de configuração.

dotnet user-secrets set "ConnectionStrings" "Server=localhost;Database=UserManagerDatabase;User Id=sa;Password=123456;" 

"ConnectionStrings" = igual o nome da chave que fica no appsettings

"Server=localhost;Database=UserManagerDatabase;User Id=sa;Password=123456;"  = Essa é a configuração do acesso ao banco.

Quando você der esses comando irá criar um arquivo no windows no seguinte local com o mesmo guid que apareceu quando 
foi executado o comando init
Só rodar essa informação no executar.

%appdata%\Microsoft\UserSecrets

No caso de Linux ou Mac

~/.microsoft/usersecrets/secrets.json