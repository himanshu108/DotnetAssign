using FarmerScheme.DataAccessLayer.Interfaces;
using FarmerScheme.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmerScheme.Controllers
{

    [System.Web.Mvc.Route("api/allbids")]
    [ApiController]
    public class BiddingController : Controller
    {


        private IBidDao _bidDao;
        public BiddingController(IBidDao bidDao)
        {

            this._bidDao = bidDao;
        }

        [System.Web.Mvc.HttpGet]


        public IActionResult FetchBids()
        {
            try
            {

                return this.Ok(_bidDao.GetBiddings());
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        private IActionResult BadRequest(string message)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(List<BidModel> bidModels)
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("{id}")]



        public IActionResult FetchBidById(int id)
        {
            try
            {

                return this.Ok(_bidDao.GetBidById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        private IActionResult Ok(BidModel bidModel)
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertBid")]
        public IActionResult Insertbid(BidModel Bid
            )
        {
            var result = _bidDao.InsertBidder(Bid
                );
            return this.CreatedAtAction(
                "InsertCrop",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = Bid
                }
                );
        }

        private IActionResult CreatedAtAction(string v, object p)
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpDelete]
        [System.Web.Mvc.Route("{id}")]
        public IActionResult DeleteBid(int id)
        {
            try
            {
                var result = _bidDao.DeleteBid(id
                  );
                return this.CreatedAtAction(
                  "DeleteCrop",
                  new
                  {
                      StatusCode = 201,
                      Response = result,
                      Data = id
                  }
                  );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
