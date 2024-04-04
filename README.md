
# Learn AZD deployment sameple

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Ffboucheros%2Flearn-azd%2Fzip-test%2Fdeployment%2Fazuredeploy.json)

1. Prepare the pacjkage
	```dotnetcli
	dotnet publish -c Release -o ./out  
	```

2. Zip the folder
3. Create a new release on GitHub with that zip file
4. Update the `azuredeploy.json` file with the new release URL
5. Click on the `Deploy to Azure` button.
