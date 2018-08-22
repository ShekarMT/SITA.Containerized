
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.Controllers
{
	/// <summary>
    /// Controller to act as endpoint for Airline related functionalities
    /// </summary>
	[Authorize]
	public class AirlineController : ApiController
	{
		#region Private Members
        private readonly IAirlineManager _AirlineManager;
        #endregion

		#region Ctor
        public AirlineController(IAirlineManager AirlineManager)
        {
            //_salesVolumeManager = salesVolumeManager;
            _AirlineManager = AirlineManager;
        }

		public AirlineController()
        {

        }

		#endregion


		#region HttpMethods

        #region HTTP POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateAirline([FromBody] Airline entity)
        {
            try
            {
                await _AirlineManager.CreateAirline(entity);
                return Ok("Created");
            }
            catch (Exception ex)
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = ex.Message
                }.ToString());
            }
        }
        #endregion

        #region HTTP GET
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var response = await _AirlineManager.GetAllAirline();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Could Not Retrieve Data"
                }.ToString());
            }
        }

        //[HttpGet]
        //public async Task<IHttpActionResult> GetAirlineById([FromUri]string id)
        //{
        //    var response = await _AirlineManager.GetAirline(id);
        //    if (response != null)
        //    {
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        return BadRequest(new SaveResult()
        //        {
        //            StatusCode = HttpStatusCode.BadRequest,
        //            Status = false,
        //            Message = "Could Not Retrieve Data"
        //        }.ToString());
        //    }
        //}
        #endregion

        #region HTTP PUT
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAirline([FromUri]string id, [FromBody] Airline updatedAirline)
        {
            var response = await _AirlineManager.UpdateAirline(id, updatedAirline);
            if (response)
            {
                return Ok(new SaveResult()
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Successfully Updated!"
                }.ToString());
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Update Unsuccessful!"
                }.ToString());
            }
        }
        #endregion

        #region HTTP DELETE
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteAirline([FromUri] string id)
        {
            var response = await _AirlineManager.DeleteAirline(id);
            if (response)
            {
                return Ok(new SaveResult()
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Successfully Updated!"
                }.ToString());
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Update Unsuccessful!"
                }.ToString());
            }
        }
        #endregion

        #endregion
	}
}

