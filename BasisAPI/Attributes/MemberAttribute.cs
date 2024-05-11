using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Results;
using System.Xml.Linq;

namespace BasisAPI.Attributes
{
    /// <summary>
    /// 會員驗證
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MemberAttribute : ActionFilterAttribute
    {
        private MemberType cvMemberType;
        public enum MemberType
        {
            會員,
            員工
        }
        public MemberAttribute()
        {
            this.cvMemberType = MemberType.會員;
        }
        public MemberAttribute(MemberType memberType)
        {
            this.cvMemberType = memberType;
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception != null)
            {
                return;
            }

            var myMemberAuthActuon = actionExecutedContext.ActionContext.ActionDescriptor.GetCustomAttributes<MemberAttribute>().FirstOrDefault();
            var myMemberAuthController = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<MemberAttribute>().FirstOrDefault();
            if (myMemberAuthActuon != null || myMemberAuthController != null)
            {
                if (!IsMemberAuthorized(actionExecutedContext.ActionContext))
                {
                    // 如果用戶未通過驗證，則回傳未授權的回應
                    actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                        HttpStatusCode.Unauthorized, "Unauthorized");
                }
            }
            base.OnActionExecuting(actionExecutedContext.ActionContext);
        }

        private bool IsMemberAuthorized(HttpActionContext context)
        {
            // TODO 驗證會員或型別....
            return true;
        }
    }
}
