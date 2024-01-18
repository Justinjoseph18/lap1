# How to migrate an azure repository to Github


## Objectives
* Migrate a single repository from Azure to github
* Migrate multiple repositories from Azure to github
* Migrate Organization from Azure to Github

## 1. Migrate a single repository from Azure to github

### Steps:
1. Download github cli
    https://cli.github.com/
2. Login and Check CLI installation instructions
    * Run 'gh auth login'
    * Two options will appear
        1. Github.com
        2. Github enterprise.com
    * From the options  choose the appropriate and click enter
    *  Another option will come to select the preffered protocoal 
        1. HTTPS
        2. SSH \
        choose the appropriate one
    * Authenticate Git with your github credentials CLICK YES
    * How would you like the authenticate Github CLI?
        1. Login with web browser
        2. paste the authentication code \
        choose the appropriate one
    * Run 'gh pr status' command \
        An fatal to run git error occours

3. Install Github Enterprise installer(GEI) extension
    * It is the tool used for the migrations
    * To see the installed extension list  =>"gh extension list"
    * To install github enterprise extension => "gh extension install github/gh-gei"
4. Generate personsl acess token of source(azure) and target(github)
    1. For source(azure)
        * login on azure
        * on the top right corner select user settings,in the menu select personal acess tokens
        * click new token 
        * On the window appears
        1. give a name you prefer
        2. select organization-your organization name
        3. expiration date
        4. scope-To run a migration from Azure DevOps (ADO), your ADO personal access token     
        5. click on create
        6. Copy the token and store somewhere 
        * personal acess token for azure\
            v4i2oplqa74l3bvqqx2x5cdb4p2hwth2v73546gojro2cd43tlba

    2. For target(github)
        * login to github
        * on profile > setting > Developersetting > Personal acess tokens > Tokens(classic) > Generate new token > Generate new token(classic)
        * on the window appears
        1. Note(give a suitable name)
        2. select scope- give the necessary scopes
        3. generate token
        4. copy the token and save it  
        * personal acess token for github\
            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
5. Setting environment variables
    * if migrating from Azure devops to Github then add the environment variables ADO_PAT&GH_PAT
    * we can add the environment variables directly(GUI) or using command line
        * In window system search for environment variables >select edit env variables > click enviroment variables > under system variables > new > under variable name "ADO_PAT"-->variable value: paste the personal token from azure devops >do the same step for adding the environment variable for Github personal token

6. setting environment variables
    * Through other CLI's\
        export GH_PAT="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"
        export ADO_PAT="v4i2oplqa74l3bvqqx2x5cdb4p2hwth2v73546gojro2cd43tlba"
    * Through Poweshell's\
        $env:GH_PAT="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"
        $env:ADO_PAT="uhiklyad65thvh3kufhnwm6d4gotekjtbqhnihm2lodmsicxih7q"

    * To verify the env variable in powershell\
        Get-Item Env:ADO_PAT\
       

7. Generating  Migrate script\
    gh ado2gh generate-script --ado-org Abelindia --github-org Technopalette --output outputscript.ps1

8. Migrating the  repository\
    gh ado2gh migrate-repo --ado-org Abelindia --ado-team-project Finder --ado-repo ai-finder-be-api-donetcore --github-org Technopalette --github-repo ai-finder-be-api-dotnetcore  


## References
    https://docs.github.com/en/migrations/using-github-enterprise-importer/migrating-repositories-with-github-enterprise-importer/migrating-repositories-from-azure-devops-to-github-enterprise-cloud