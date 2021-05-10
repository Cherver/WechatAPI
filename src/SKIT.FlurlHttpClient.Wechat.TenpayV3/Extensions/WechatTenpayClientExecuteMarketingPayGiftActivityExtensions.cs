﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供支付有礼相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingPayGiftActivityExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/unique-threshold-activity 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingPayGiftActivityUniqueThresholdActivityResponse> ExecuteCreateMarketingPayGiftActivityUniqueThresholdActivityAsync(this WechatTenpayClient client, Models.CreateMarketingPayGiftActivityUniqueThresholdActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "marketing", "paygiftactivity", "unique-threshold-activity")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingPayGiftActivityUniqueThresholdActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPayGiftActivityByActivityIdResponse> ExecuteGetMarketingPayGiftActivityByActivityIdAsync(this WechatTenpayClient client, Models.GetMarketingPayGiftActivityByActivityIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId)
                .SetOptions(request);

            return await client.SendRequestAsync<Models.GetMarketingPayGiftActivityByActivityIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivitiesResponse> ExecuteQueryMarketingPayGiftActivitiesAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "marketing", "paygiftactivity", "activities")
                .SetOptions(request)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            if (!string.IsNullOrEmpty(request.ActivityName))
                flurlReq.SetQueryParam("activity_name", request.ActivityName);

            if (!string.IsNullOrEmpty(request.ActivityStatus))
                flurlReq.SetQueryParam("activity_status", request.ActivityStatus);

            if (!string.IsNullOrEmpty(request.AwardType))
                flurlReq.SetQueryParam("award_type", request.AwardType);

            return await client.SendRequestAsync<Models.QueryMarketingPayGiftActivitiesResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateMarketingPayGiftActivityResponse> ExecuteTerminateMarketingPayGiftActivityAsync(this WechatTenpayClient client, Models.TerminateMarketingPayGiftActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "marketing", "paygiftactivity", "activities", request.ActivityId, "terminate")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.TerminateMarketingPayGiftActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddMarketingPayGiftActivityMerchantResponse> ExecuteAddMarketingPayGiftActivityMerchantAsync(this WechatTenpayClient client, Models.AddMarketingPayGiftActivityMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants", "add")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.AddMarketingPayGiftActivityMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id}/merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivityMerchantsResponse> ExecuteQueryMarketingPayGiftActivityMerchantsAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivityMerchantsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants")
                .SetOptions(request);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestAsync<Models.QueryMarketingPayGiftActivityMerchantsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_10.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMarketingPayGiftActivityMerchantResponse> ExecuteDeleteMarketingPayGiftActivityMerchantAsync(this WechatTenpayClient client, Models.DeleteMarketingPayGiftActivityMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Delete, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants", "delete")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.DeleteMarketingPayGiftActivityMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id}/goods 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_7_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_7_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivityGoodsResponse> ExecuteQueryMarketingPayGiftActivityGoodsAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivityGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId, "goods")
                .SetOptions(request);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestAsync<Models.QueryMarketingPayGiftActivityGoodsResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
