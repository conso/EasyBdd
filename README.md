# EasyBdd - Behaviour Driven Development framework based on one abstract class only
### The lightweight, uninvasive, super extensible BDD tool for .NET written in c#. 
In 10 minutes you will be hooked and already back focusing on your tests using it!

##Quick start
  1) reference EasyBdd and Nunit

        using EasyBdd;
        using NUnit.Framework;

  2) inherit from BddSpecification with a partial class

        public partial class RefundSpecifications : BddSpecification

  3) write your tests

        [Test]
        public void Refunded_items_should_be_returned_to_stock()
        {
            Given(customer_previously_bought_an_item);
            And(I_currently_have_four_items_in_stock);
            When(he_returns_the_item_for_a_return);
            Then(I_should_have_five_items_in_stock);
        }

  4) create another partial on a different file (for convention we suffix it "Steps" but you can chose any file name

        [TestFixture]
        public partial class RefundSpecifications

  5) define the methods of the steps in this class

        private void customer_previously_bought_an_item()
        {
            _target.CustomerBuy(1);
        }

##What you achieve
  - A neat way to separate the definitions of your behaviours that any tester can pick up with little effort. It's ideal for an approach "Acceptance Tests First", where tester prepare the scheletons of the tests directly in to the solution. Such a time saver!!
  - The paradigm Given-When-Then-And built in the base class exposing the methods. 
  - Run tests in native NUnit along with all other tests in your CI environment, no need to add scripts for new tools.
  - If you need documentation you can easily write a parser to save the specs in well formatted documents (Basically it's not my code being generated from the docs, but the other way around!)

##Side notes
I wrote this little code snippet some time ago, when in our team the discussions about "what BDD framework?" begun. I used some popular tools in the past and the cleanliness of the language was inevitably traded off with terrible solutions like old fashioned auto-generated code. There is nothing I hate more then a tool which create noise behind the scene (and get in the way every time I need to debug a test.... grrrrr!!!) So I always had this idea in mind: if we move the trade off in the ubiquitous specification language page, we can keep the codebase cleaner, while a business person is not so stupid to be scared by something that start with "public class", as far as it is easy enough to read and modify common language into it.

I gave it a go and I came out with this little solution that I still currently use.

It still has some compromises (like using underscores instead then white space) but it does its job damn well. As far as some fellow developers kept pestering me to publish it open source... so here we go!

Hope you enjoy it, the example included should be clear enough.