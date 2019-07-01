## PR Checklist (`nothing above this line`)
*MUST check if your PR fulfills the following requirements* (`MUST FILL OUT - DO NOT DELETE`):
 
- [ ] PR Title format (`MUST always ex. FO-38393 - (3.3) - Added Field to Order Model`)
 
### General
- The commit message follows our guidelines:
  - [ ] UI provide screen shots "always" when working in UI
  - [ ] API provide screen shots of the API in Swagger "preferred" or Postman
 
### Tests
- `Xunit Tests` for the changes have been added (for bug fixes / features) (`if applicable`).
  - [ ] ApiClients (`MUST always`)
  - [ ] Controller Api (`if applicable`)
 
### Documentation
- Docs have been added / updated (for bug fixes / features)
  - [ ] XML comments on all Api controller methods (`MUST or PR will be rejected`)
  - [ ] XML comments on all models used by Api controllers (`MUST or PR will be rejected`)
 
### Double check each file
  - [ ] Config/json files must be transformed (`if applicable`)
   
Format Issues (`MUST check some but not all below`)
#### C#
- [ ] C# - remove any extra whitespaces and/or blank lines
- [ ] C# - follow correct layout, field(s), constructor(s), properties, and then method(s)
- [ ] C# - use implicit over explicit if applicable
- [ ] C# - camcelCase for all local variables (`MUST or PR will be rejected`)
- [ ] C# - descriptive variables (`MUST or PR will be rejected`)
- [ ] C# - use [CodeMaid](http://www.codemaid.net/) (`recommended extension`)
- [ ] C# - run custom tool on .tt template files (`MUST or PR will be rejected`)
- [ ] C# - use [string interpolation](https://en.wikipedia.org/wiki/String_interpolation) over string.format or concatenation with +
   
### Verify
`MUST Check off all or PR will be rejected`
- [ ] Verify all files in PR are the only changes related to the commit in hand
- [ ] Verify the base: branch (`know where the code it being deployed`)
- [ ] Double check shared services [dependencies](https://confluence.xpo.com/pages/viewpage.action?pageId=114626580) (`prevent breaking changes`)
- [ ] Double check [release components](https://confluence.xpo.com/display/XPODEV/Release+Status) (`go to the most current release`)
 
 
## PR Type
### What kind of change does this PR introduce?
`MUST check at least one that applies to this PR using "x".`
- [ ] Bugfix
- [ ] Feature
- [ ] Forward Merge
- [ ] Back Merge
- [ ] Code style update (formatting, local variables, etc..)
- [ ] Refactoring (no functional changes, no api changes)
- [ ] Build related changes
- [ ] Deploy related changes
- [ ] CI related changes
- [ ] Documentation content changes
- [ ] Other... Please describe:
 
### What is the current behavior? (`Please describe briefly`)
 
*Issue Number* (`MUST copy and paste URL from jira ex. https://jira.xpo.com/browse/[JIRATICKET]`):
 
 
### What is the new behavior? (`Please describe`)
 
 
## Does this PR introduce a breaking change?
- [ ] Yes (`MUST explain`)
- [ ] No
 
 
`If this PR contains a breaking change, please describe the impact and migration path for existing applications below.`
 
 
 
## Other information Comments and/or Screenshots ([Attach files to PRs](https://help.github.com/articles/file-attachments-on-issues-and-pull-requests/))
 
 
 
## Other references
- Follow xpo conventions/standards (`double check`)
  - [ ] [C#]()
  - [ ] [GIT](https://github.com/xpologistics/xpo-conventions/tree/master/git)
  - [ ] [API](https://github.com/xpologistics/xpo-conventions/tree/master/api)
  - [ ] [PR Checklist](https://confluence.xpo.com/pages/viewpage.action?pageId=122164754)
 
 
## Other information
- [ ] After the PR is merged into branch please copy the link of the commit into the jira task.
