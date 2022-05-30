# PROJETO API REST (CORE)
> Criar uma API Web com ASP.NET Core

## Pré-requisitos
> Protocolo HTTP
* [Visão geral do HTTP](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Overview)
* [Mensagens HTTP](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Messages)
* [Códigos de status de respostas HTTP](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status)

> REST 
* Transferência Representacional de Estado (Representational State Transfer)

> Arquitetura REST 
* Logica de negócios é distribuída em APIs REST (interfaces bem definidas, responsabilidade única e independente
* A comunicação realizada por mensagem HTTP baseada em texto com formato padronizado (geralmente JSON), permitindo que diferentes tecnologias se comuniquem.  

> ASP NET Core 
* [Documentação do ASP.NET](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-6.0)
* [Modelos padrão do .NET para dotnet new](https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-new-sdk-templates)
* [.NET Platform](https://github.com/dotnet)

> Linha comando:
  
```
dotnet new webapi -n <nome_do_projeto>
```

* Executar projeto:
``` 
cd <nome_do_projeto>
dotnet watch run
```

* Carregar o projeto no [Visual Studio Code](https://code.visualstudio.com/)

```
code . 
```

## Controller

> [APIs Web com o ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-6.0 )
 
```
[Route("api/[controller]")]
public class TestesController : ControllerBase  
... 
    //GET api/testes/obter-por-id/5
    [HttpGet("obter-por-id/{id:int}")] 
    public IActionResult Get(int id)
	
...

	[HttpGet(]
	public ActionResult<IEnumerable<string>> Obter()
	{
		... 
		if(!valid)
			return BadRequest();
		retrun new string[]{"teste"};
	}    
```

> Atributos 
<table>
  <thead>
    <tr>
      <th>Atributo</th>
      <th>Origem de associação</th>
    </tr>
  </thead>
 <tbody> 
    <tr>
      <td>[FromBody]</td> <td>Corpo da solicitação</td>      
    <tr>
      <td>[FromForm]</td><td>Dados do formulário no corpo da solicitação</td>      
    <tr>
      <td>[FromHeader]</td><td>Cabeçalho da solicitação</td>      
    <tr>
      <td>[FromQuery]</td><td>Parâmetro de cadeia de caracteres de consulta de solicitação</td>      
    <tr>
      <td>[FromRoute]</td><td>Dados de rota da solicitação atual</td>      
    <tr>
      <td>[FromServices]</td><td>O serviço de solicitação inserido como um parâmetro de ação</td>      
    <tr>
</tbody> 
</table>


> [ApiConventions](https://docs.microsoft.com/pt-br/aspnet/core/web-api/advanced/conventions?view=aspnetcore-6.0)
 
```
[HttpPost]
[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
[ProducesResponseType(StatusCodes.Status404NotFound)]
public IActionResult Post(Produto obj)
{
    if (!_repository.TryGetProduct(id, out var product))
    {
        return NotFound();
    }

    return Ok(product);
}
```


> Retorno Customizado 

``` 
protected ActionResult RetornoPadrao(object obj = null)
{
    if (Validar())
    {
        return Ok(new {sucesso = true, data = obj});
    }

    return BadRequest( new {sucesso = false, errors = ObterErrors() });
}
```

## Migrations 

> Criar tabelas 
```
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.25

Add-Migration CriarTabelas -OutputDir "Areas/CAD/Migrations"
```
> Criar o banco 
```
	update-database –verbose
```

## Status
![GitHub repo size](https://img.shields.io/github/repo-size/danps/restapi?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/danps/restapi?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/danps/restapi?style=for-the-badge) 
