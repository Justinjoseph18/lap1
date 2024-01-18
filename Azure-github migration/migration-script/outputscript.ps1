#!/usr/bin/env pwsh

# =========== Created with CLI version 1.1.0.0 ===========

function Exec {
    param (
        [scriptblock]$ScriptBlock
    )
    & @ScriptBlock
    if ($lastexitcode -ne 0) {
        exit $lastexitcode
    }
}

function ExecAndGetMigrationID {
    param (
        [scriptblock]$ScriptBlock
    )
    $MigrationID = & @ScriptBlock | ForEach-Object {
        Write-Host $_
        $_
    } | Select-String -Pattern "\(ID: (.+)\)" | ForEach-Object { $_.matches.groups[1] }
    return $MigrationID
}

function ExecBatch {
    param (
        [scriptblock[]]$ScriptBlocks
    )
    $Global:LastBatchFailures = 0
    foreach ($ScriptBlock in $ScriptBlocks)
    {
        & @ScriptBlock
        if ($lastexitcode -ne 0) {
            $Global:LastBatchFailures++
        }
    }
}

if (-not $env:ADO_PAT) {
    Write-Error "ADO_PAT environment variable must be set to a valid Azure DevOps Personal Access Token with the appropriate scopes. For more information see https://docs.github.com/en/migrations/using-github-enterprise-importer/preparing-to-migrate-with-github-enterprise-importer/managing-access-for-github-enterprise-importer#personal-access-tokens-for-azure-devops"
    exit 1
} else {
    Write-Host "ADO_PAT environment variable is set and will be used to authenticate to Azure DevOps."
}

if (-not $env:GH_PAT) {
    Write-Error "GH_PAT environment variable must be set to a valid GitHub Personal Access Token with the appropriate scopes. For more information see https://docs.github.com/en/migrations/using-github-enterprise-importer/preparing-to-migrate-with-github-enterprise-importer/managing-access-for-github-enterprise-importer#creating-a-personal-access-token-for-github-enterprise-importer"
    exit 1
} else {
    Write-Host "GH_PAT environment variable is set and will be used to authenticate to GitHub."
}

$Succeeded = 0
$Failed = 0
$RepoMigrations = [ordered]@{}

# =========== Queueing migration for Organization: Abelindia ===========

# === Queueing repo migrations for Team Project: Abelindia/Finder ===

$MigrationID = ExecAndGetMigrationID { gh ado2gh migrate-repo --ado-org "Abelindia" --ado-team-project "Finder" --ado-repo "ai-finder-fe-web-business-react-test" --github-org "Abel-India" --github-repo "Finder-ai-finder-fe-web-business-react-test" --queue-only --target-repo-visibility private }
$RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react-test"] = $MigrationID

$MigrationID = ExecAndGetMigrationID { gh ado2gh migrate-repo --ado-org "Abelindia" --ado-team-project "Finder" --ado-repo "ai-finder-fe-web-business-react" --github-org "Abel-India" --github-repo "Finder-ai-finder-fe-web-business-react" --queue-only --target-repo-visibility private }
$RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react"] = $MigrationID

$MigrationID = ExecAndGetMigrationID { gh ado2gh migrate-repo --ado-org "Abelindia" --ado-team-project "Finder" --ado-repo "ai-finder-be-api-donetcore" --github-org "Abel-India" --github-repo "Finder-ai-finder-be-api-donetcore" --queue-only --target-repo-visibility private }
$RepoMigrations["Abelindia/Finder-ai-finder-be-api-donetcore"] = $MigrationID

# =========== Waiting for all migrations to finish for Organization: Abelindia ===========

# === Waiting for repo migration to finish for Team Project: Finder and Repo: ai-finder-fe-web-business-react-test. Will then complete the below post migration steps. ===
$CanExecuteBatch = $false
if ($null -ne $RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react-test"]) {
    gh ado2gh wait-for-migration --migration-id $RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react-test"]
    $CanExecuteBatch = ($lastexitcode -eq 0)
}
if ($CanExecuteBatch) {
    $Succeeded++
} else {
    $Failed++
}

# === Waiting for repo migration to finish for Team Project: Finder and Repo: ai-finder-fe-web-business-react. Will then complete the below post migration steps. ===
$CanExecuteBatch = $false
if ($null -ne $RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react"]) {
    gh ado2gh wait-for-migration --migration-id $RepoMigrations["Abelindia/Finder-ai-finder-fe-web-business-react"]
    $CanExecuteBatch = ($lastexitcode -eq 0)
}
if ($CanExecuteBatch) {
    $Succeeded++
} else {
    $Failed++
}

# === Waiting for repo migration to finish for Team Project: Finder and Repo: ai-finder-be-api-donetcore. Will then complete the below post migration steps. ===
$CanExecuteBatch = $false
if ($null -ne $RepoMigrations["Abelindia/Finder-ai-finder-be-api-donetcore"]) {
    gh ado2gh wait-for-migration --migration-id $RepoMigrations["Abelindia/Finder-ai-finder-be-api-donetcore"]
    $CanExecuteBatch = ($lastexitcode -eq 0)
}
if ($CanExecuteBatch) {
    $Succeeded++
} else {
    $Failed++
}

Write-Host =============== Summary ===============
Write-Host Total number of successful migrations: $Succeeded
Write-Host Total number of failed migrations: $Failed

if ($Failed -ne 0) {
    exit 1
}


