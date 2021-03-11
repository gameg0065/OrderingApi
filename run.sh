#!/bin/bash

if [ $1 == "test" ]; then
   dotnet test
else 
   dotnet run -p ./orderingApi/orderingApi.csproj
fi
