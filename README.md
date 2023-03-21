# ChoDesignWebTest
Project of Software Release Management in Term 1, March 2023. Focusing on source and version control through GitHub Desktop, Git Bash, and GitHub browser.

Frameworks used in this website's creation:
1. ASP .NET Core MVC 6
2. Bootstrap 5 (JS included)

jQuery plugins used:
1. Maphilight by David Lynch https://github.com/kemayo/maphilight
2. RWD Image Maps by Matt Stow https://github.com/stowball/jQuery-rwdImageMaps/


Scenario used for the website:

Your company, Curio Design Limited, have been approached by a client to develop a website to showcase her design projects. She wants each project to have its own page, with unique colour schemes to differentiate each other.

The basic requirements that she needs in her website are:

1. A navigation bar on every page to ease user switching between pages.
2. Homepage: It should show linked images to get the user to different pages. 
3. About webpage: It should contain information about the client, and how to reach her through contact information and social media, also with an email form to directly contact her through the website.
4. Deceit (Year 12) webpage: It should contain her design work titled Deceit, showcasing the folio board. Along with an updated Deceit design for comparison.
5. Entropy (Year 13) webpage: It should contain her design work titled Entropy, showcasing the folio board. Along with an updated Entropy design for comparison.

Note: The content of the website is based on my last year's extra project, Design_Portfolio_Boards.

---
UPDATE 16/03/2023:

Applying CI/CD (Continuous Integration/Continuous Deployment) method.

For CI, I'm using Github Actions' workflows (currently .NET workflow).

For CD, I deployed this repo through Microsoft Azure. Azure automatically create CD workflow if you enable CD during App Service creation.

Website link: https://ocidesigns2.azurewebsites.net/
