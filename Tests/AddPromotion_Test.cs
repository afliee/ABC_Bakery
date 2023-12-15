using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Services;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ABC_Bakery.Tests
{
    [TestFixture]
    internal class AddPromotion_Test
    {
        private PromotionService _promotionService;
        [SetUp]
        public void Setup()
        {
            _promotionService = PromotionService.GetInstance();
        }

        [Test]
        public void AddNewPromotion_Test()
        {
            // arrange
            string Promotion_Name = "Khuyến Mãi 1";
            string Promotion_Code = "KHUYENMAI1";
            int Promotion_Ratio = 10;
            DateTime Promotion_EndDate = DateTime.Now.AddDays(7);

            // act
            var promotion = _promotionService.FindByCode(Promotion_Code);
            if (promotion != null)
            {
                // pass
                Assert.Pass("Promotion Already Exist");
                return;
            }


            promotion = new Models.Promotion
            {
                Name = Promotion_Name,
                Code = Promotion_Code,
                Ratio = Promotion_Ratio,
                ExpiredAt = Promotion_EndDate,
            };

            _promotionService.Create(Promotion_Name, Promotion_Code, Promotion_Ratio, Promotion_EndDate);

            // assert
            promotion = _promotionService.FindByCode(Promotion_Code);
            ClassicAssert.IsNotNull(promotion);
            ClassicAssert.AreEqual(Promotion_Name, promotion.Name);
            ClassicAssert.AreEqual(Promotion_Code, promotion.Code);
            ClassicAssert.AreEqual(Promotion_Ratio, promotion.Ratio);
        }
    }
}
