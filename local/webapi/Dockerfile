FROM microsoft/dotnet:sdk
WORKDIR /webapi
COPY . .

RUN dotnet restore
RUN dotnet build
RUN dotnet publish

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

RUN chmod +x ./entrypoint.sh
ENTRYPOINT [ "/bin/bash", "./entrypoint.sh" ]


# FROM microsoft/dotnet:sdk

# WORKDIR /webapi
# COPY bin/Debug/netcoreapp2.1/publish .

# ENV ASPNETCORE_URLS http://+:5000
# EXPOSE 5000

# #ENTRYPOINT ["dotnet", "webapi.dll"]

# ADD entrypoint.sh .

# RUN chmod +x ./entrypoint.sh
# ENTRYPOINT [ "/bin/bash", "./entrypoint.sh" ]

# FROM microsoft/dotnet:sdk AS build-env
# WORKDIR /app

# # Copy csproj and restore as distinct layers
# COPY *.csproj ./
# RUN dotnet restore

# # Copy everything else and build
# COPY . ./
# RUN dotnet publish -c Release -o out

# # Build runtime image
# FROM microsoft/dotnet:aspnetcore-runtime
# WORKDIR /app
# COPY --from=build-env /app/out .

# ENV ASPNETCORE_URLS http://+:5000
# EXPOSE 5000

# ADD entrypoint.sh .

# RUN chmod +x ./entrypoint.sh
# # # #SEMI WORKING
# CMD /bin/bash ./entrypoint.sh




# # FROM microsoft/aspnetcore:2.1
# FROM microsoft/dotnet:sdk

# WORKDIR /webapi
# COPY bin/Debug/netcoreapp2.1/publish .

# ENV ASPNETCORE_URLS http://+:5000
# EXPOSE 5000

# # ENTRYPOINT ["dotnet", "webapi.dll"]
# #SEMI WORKING
# ADD entrypoint.sh .

# RUN chmod +x ./entrypoint.sh
# # #SEMI WORKING
# CMD /bin/bash ./entrypoint.sh