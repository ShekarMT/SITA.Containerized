
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.Controllers
{
	/// <summary>
    /// Controller to act as endpoint for AssignedAirportToAirlineMapp related functionalities
    /// </summary>
	[Authorize]
	public class AssignedAirportToAirlineMappController : ApiController
	{
		#region Private Members
        private readonly IAssignedAirportToAirlineMappManager _AssignedAirportToAirlineMappManager;
        #endregion

		#region Ctor
        public AssignedAirportToAirlineMappController(IAssignedAirportToAirlineMappManager AssignedAirportToAirlineMappManager)
        {
            //_salesVolumeManager = salesVolumeManager;
            _AssignedAirportToAirlineMappManager = AssignedAirportToAirlineMappManager;
        }

		public AssignedAirportToAirlineMappController()
        {

        }

		#endregion


		#region HttpMethods

        #region HTTP POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateAssignedAirportToAirlineMapp([FromBody] AssignedAirportToAirlineMapp entity)
        {
            try
            {
                await _AssignedAirportToAirlineMappManager.CreateAssignedAirportToAirlineMapp(entity);
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
            var response = await _AssignedAirportToAirlineMappManager.GetAllAssignedAirportToAirlineMapp();
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
        //public async Task<IHttpActionResult> GetAssignedAirportToAirlineMappById([FromUri]string id)
        //{
        //    var response = await _AssignedAirportToAirlineMappManager.GetAssignedAirportToAirlineMapp(id);
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
        public async Task<IHttpActionResult> UpdateAssignedAirportToAirlineMapp([FromUri]string id, [FromBody] AssignedAirportToAirlineMapp updatedAssignedAirportToAirlineMapp)
        {
            var response = await _AssignedAirportToAirlineMappManager.UpdateAssignedAirportToAirlineMapp(id, updatedAssignedAirportToAirlineMapp);
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
        public async Task<IHttpActionResult> DeleteAssignedAirportToAirlineMapp([FromUri] string id)
        {
            var response = await _AssignedAirportToAirlineMappManager.DeleteAssignedAirportToAirlineMapp(id);
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

