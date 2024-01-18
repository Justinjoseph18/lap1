# Migrate repository from AzureDevOps(Repository) to GitHub
1. Download [Github cli](https://cli.github.com/) tool.
2. Login and Check CLI installation
    * Open your terminal and run the following command: 'gh auth login' * Choose the appropriate GitHub option (GitHub.com or GitHub Enterprise)
    * Choose your preferred protocol (HTTPS or SSH), authenticate with GitHub credentials by selecting "Login with a web browser," and follow the prompts to complete the authentication process.
    * Run "gh pr status" to verify the CLI installation.
3. Install GitHub Enterprise Installer (GEI) Extension:
    * To install the GitHub Enterprise extension, run "gh extension install github/gh-gei" and verify the installation using "gh pr status"
4. Generate Personal Access Tokens (PAT):
    1. For Source (Azure):
        * Log in to Azure, go to User Settings, create a new token with a name, organization, expiration date, and necessary scopes, then click "Create" to generate and copy the PAT for Azure.PAT must have work item (read), code (read), and identity (read) scopes.
    2. For Target (GitHub):
        * Log in to GitHub, navigate to Profile > Settings > Developer settings > Personal access tokens > Tokens (classic), create a new token with a name and required scopes, generate it, and then copy and save the PAT for GitHub.PAT must have repo, admin:org, workflow scopes.
5. Set Environment Variables:
    * When migrating from Azure DevOps to GitHub, set the environment variables ADO_PAT and GH_PAT by adding them in your system's environment variables with their respective PAT values.
6. Generate Migration Script:
    * To generate a migration script, run,
    > gh ado2gh generate-script --ado-org SOURCE --github-org DESTINATION --output FILENAME


        Replace the placeholders with the following:
            * SOURCE	    Name of the source organization
            * DESTINATION	Name of the destination organization
            * FILENAME	    A filename for the resulting migration script
7. Migrate the Repository:
    * To migrate to the repository run,
    >gh ado2gh migrate-repo --ado-org SOURCE --ado-team-project TEAM-PROJECT --ado-repo CURRENT-NAME --github-org DESTINATION --github-repo NEW-NAME\
    
    Replace the placeholders with the following:

            SOURCE        Name of the source organization
            CURRENT-NAME  The name of the repository you want to migrate
            DESTINATION   Name of the destination organization
            NEW-NAME	   The name you want the migrated repository to have
            TEAM-PROJECT  Name of the team project of the repository you want to migrate
## References

 [Migrating repositories from Azure DevOps to GitHub Enterprise Cloud](https://docs.github.com/en/migrations/using-github-enterprise-importer/migrating-repositories-with-github-enterprise-importer/migrating-repositories-from-azure-devops-to-github-enterprise-cloud)\
 [Managing access for GitHub Enterprise Importer](https://docs.github.com/en/migrations/using-github-enterprise-importer/preparing-to-migrate-with-github-enterprise-importer/managing-access-for-github-enterprise-importer#required-scopes-for-personal-access-tokens)