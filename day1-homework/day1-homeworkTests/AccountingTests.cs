using System.Collections.Generic;
using day1homework;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace day1_homeworkTests
{
    [TestClass]
    public class AccountingTests
    {
        private IOrderDao _OrderDao;

        private void SetupDataDao(int dataCount)
        {
            _OrderDao = Substitute.For<IOrderDao>();
            var datas = new List<Order>();
            for (var i = 1; i <= dataCount; i++)
            {
                var data = new Order
                {
                    Id = i,
                    Cost = i,
                    Revenue = 10 + i,
                    SellPrice = 20 + i
                };
                datas.Add(data);
            }
            _OrderDao.GetOrders().Returns(datas);
        }

        [TestMethod]
        public void GetCost_ShouldReturnSumUpEveryThreeRecords()
        {
            // Arrange
            SetupDataDao(11);
            var target = new Accounting(_OrderDao);
            var expected = new List<int>
            {
                6,
                15,
                24,
                21
            };

            // Act
            var actual = target.GetCosts();

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void GetCost_ShouldReturnSumUpIfRecordsLessThan3()
        {
            // Arrange
            SetupDataDao(2);
            var target = new Accounting(_OrderDao);
            var expected = new List<int>
            {
                3
            };

            // Act
            var actual = target.GetCosts();

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void GetRevenue_ShouldReturnSumUpEveryFourRecords()
        {
            // Arrange
            SetupDataDao(11);
            var target = new Accounting(_OrderDao);
            var expected = new List<int>
            {
                50,
                66,
                60
            };

            // Act
            var actual = target.GetRevenues();

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void GetRevenue_ShouldReturnSumUpIfLessThan4()
        {
            // Arrange
            SetupDataDao(2);
            var target = new Accounting(_OrderDao);
            var expected = new List<int>
            {
                23
            };

            // Act
            var actual = target.GetRevenues();

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}