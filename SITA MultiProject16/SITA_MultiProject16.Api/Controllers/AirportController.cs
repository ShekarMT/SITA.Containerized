
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.Controllers
{
	/// <summary>
    /// Controller to act as endpoint for Airport related functionalities
    /// </summary>
	[Authorize]
	public class AirportController : ApiController
	{
		#region Private Members
        private readonly IAirportManager _AirportManager;
        #endregion

		#region Ctor
        public AirportController(IAirportManager AirportManager)
        {
            //_salesVolumeManager = salesVolumeManager;
            _AirportManager = AirportManager;
        }

		public AirportController()
        {

        }

		#endregion


		#region HttpMethods

        #region HTTP POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateAirport([FromBody] Airport entity)
        {
            try
            {
                await _AirportManager.CreateAirport(entity);
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
            var response = await _AirportManager.GetAllAirport();
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
        //public async Task<IHttpActionResult> GetAirportById([FromUri]string id)
        //{
        //    var response = await _AirportManager.GetAirport(id);
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
        public async Task<IHttpActionResult> UpdateAirport([FromUri]string id, [FromBody] Airport updatedAirport)
        {
            var response = await _AirportManager.UpdateAirport(id, updatedAirport);
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
        public async Task<IHttpActionResult> DeleteAirport([FromUri] string id)
        {
            var response = await _AirportManager.DeleteAirport(id);
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

