# EasyBdd
The lightweight, uninvasive Bdd framework for .NET written in c#

In effect calling it a "framework" it is maybe an euphemism. One single abstract class will give the infrastructure to write readable code that business people and testers can easily understand, change and fix.

I wrote this little code snippet some time ago, when in our team the discussions about "what BDD framework?" begun. I used some popular tools in the past and the cleanliness of the language was inevitably traded off with terrible solutions like old fashioned auto-generated code. There is nothing I hate more then a tool which create noise behind the scene (and get in the way every time I need to debug a test.... grrrrr!!!) So I always had this idea in mind: if we move the trade off in the ubiquitous specification language page, we can keep the codebase cleaner, while a business person is not so stupid to be scared by something that start with "public class", as far as it is easy enough to read and modify common language into it.

I gave it a go and I came out with this little solution that we still currently use for our acceptance criteria.

It still have a little bit of compromises (like using underscores instead then white space) but it does its job damn well in our team, as far as a few fellow developers keep pestering me to publish it open source... so here we go!

Hope you enjoy it, the example included should be clear enough.
