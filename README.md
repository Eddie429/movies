# movies
A database about movies

## How to run projects?
```bash
#Firstly run the backend
cd Back
dotnet run
#backend creates a sqlite database automatically. It is initilized with some data
#now, open another command prompt (terminal) and run the frontend
#consider that the URL of the backend is hard coded in the frontend
cd Front
npm i #first time only
npm start
#no open the browser with address http://localhost:3000/ and see the application
```

## Useful commands
```bash
#create a new project
dotnet new webapi --name Movies --use-controllers

#create a class in a specific folder
dotnet new class --output Entities --name Movie

git archive --format zip --output movies.zip main
```
