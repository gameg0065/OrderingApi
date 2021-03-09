#!/bin/bash

if [ $1 == "tests" ]; then
   dotnet test
else 
   dotnet run -p ./orderingApi/orderingApi.csproj
fi
