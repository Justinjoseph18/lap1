# personal acess token for github(15-10-2023)

* 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

# personal acess token for azure(15-10-2023)

* 237l73xmnbh36jp2hoccsv7rwklqvupvtkuywyhslioktvtl2luq
  
# environment variables

export GH_PAT="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"
export ADO_PAT="v4i2oplqa74l3bvqqx2x5cdb4p2hwth2v73546gojro2cd43tlba"

# Migrate script

gh ado2gh generate-script --ado-org Abelindia --github-org Technopalette --output migration.ps1

# Migrate repository

gh ado2gh migrate-repo --ado-org Abelindia --ado-team-project Finder --ado-repo ai-finder-be-api-donetcore --github-org Technopalette --github-repo ai-finder-be-api-donetcore