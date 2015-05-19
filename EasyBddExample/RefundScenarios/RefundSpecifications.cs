using EasyBdd;
using NUnit.Framework;

namespace EasyBddExample.RefundScenarios
{
    
    public partial class RefundSpecifications : BddSpecification
    {
        [Test]
        public void Refunded_items_should_be_returned_to_stock()
        {
            Given(customer_previously_bought_an_item);
            And(I_currently_have_four_items_in_stock);
            When(he_returns_the_item_for_a_return);
            Then(I_should_have_five_items_in_stock);
        }

        [Test]
        public void Refunded_items_should_not_be_with_the_customer_anymore()
        {
            Given(customer_previously_bought_an_item);
            When(he_returns_the_item_for_a_return);
            Then(he_should_have_zero_items);
        }
    }
}