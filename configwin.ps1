[Environment]::SetEnvironmentVariable(
  "Path",
  $Env:Path + ";$HOME\bin",
  "User"
)
