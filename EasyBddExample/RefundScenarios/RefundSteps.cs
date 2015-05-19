using EasyBddExample.TargetExample;
using NUnit.Framework;

namespace EasyBddExample.RefundScenarios
{
    [TestFixture]
    public partial class RefundSpecifications
    {
        private TargetObject _target;

        protected override void Before()
        {
            _target = new TargetObject();
        }

        private void customer_previously_bought_an_item()
        {
            _target.CustomerBuy(1);
        }

        private void I_currently_have_four_items_in_stock()
        {
            _target.SetStock(4);
        }

        private void he_returns_the_item_for_a_return()
        {
            _target.CustomerReturnItem();
        }

        private void I_should_have_five_items_in_stock()
        {
            Assert.That(_target.Stock, Is.EqualTo(5));
        }

        private void he_should_have_zero_items()
        {
            Assert.That(_target.CustomerItems, Is.EqualTo(0));
        }
    }
}
