# Appcopier
### Back up key things on your Windows PC, perform a reset or simply go back in time.

https://github.com/builtbybel/Appcopier/assets/57478606/4e6d88ee-1863-4617-bdc8-20da40ff0cb6

This small project is still in the making. It allows you to back up and restore your most important Windows 11 preferences and settings offline and locally. The app [mimics the new backup app of Windows 11](https://support.microsoft.com/en-us/windows/back-up-your-windows-pc-87a81f8a-78fa-456e-b521-ac0560e32338) -  which is part of the Windows 11 2023 Update (23H2) - but without the obligation of the cloud. I will certainly expand and enhance it over time.  I, for example, don't understand why one cannot uninstall the new (old) Windows backup app and why it is supposed to be a 'system component'.There is any way to opt out, not even via Group Policy configurable. Even on Enterprise devices but its an consumer targeted app!?  In my eyes, the entire Windows Backup app is essentially a facade, primarily designed to promote the use of OneDrive.  Although the Windows Backup app appears to be merely a front-end for the already 77 existing sync experiences around the OneDrive app. Maybe we can achieve better results with Appcopier.

How does Appcopier works? Quite simple! Only registry entries and/or associated folders and files of the respective area are exported. This process is very quick and lightweight, akin to the weight of a fly. So don't be surprised if the first backups fly through in the nanosecond range. For the future, I could envision an addition of a more dynamic option in the form of scripts/plugins, where even more complex things could be backed up.

The project might remind some of you of one of my first public projects - CloneApp. It's been a long time. I wrote CloneApp back in the day with Classic Visual Basic 6 and Delphi, and eventually, I abandoned its maintenance. 

I've written and tested **Appcopier on Windows 11**, but it should also run on Windows 10 (no guarantee from me, though). Give it a try! This is the first release, and there's more to come.


DISCLAIMER: This app only backs up the options selected, it won't back up everything. If you will reset your PC or sell the PC, back up the entire AppData folder just in case something is missing.


