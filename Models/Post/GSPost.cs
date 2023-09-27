using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhereIsPackage.Models.Post;

namespace WhereIsPackage.Models
{
    public class GSPost : CommomPost
    {
        /// <summary>
        /// 택배 종류
        /// </summary>
        public string serviceType { get; set; }
        /// <summary>
        /// 가장 최근의 트래킹
        /// </summary>
        public TrackingDetail latestTrackingDetail { get; set; }
        /// <summary>
        /// 받는사람
        /// </summary>
        public User receiver { get; set; }
        /// <summary>
        /// 보내는 사람
        /// </summary>
        public User sender { get; set; }
        /// <summary>
        /// 배송 추적 정보
        /// </summary>
        public List<TrackingDetail> trackingDetails { get; set; }
        /// <summary>
        /// 운송장 번호
        /// </summary>
        public string invoiceNo { get; set; }
        /// <summary>
        /// 택배 이름 (종류?)
        /// </summary>
        public string serviceName { get; set; }
        /// <summary>
        /// 상품 이름
        /// </summary>
        public string goodsName { get; set; }

    }

    /// <summary>
    /// 트래킹
    /// </summary>
    public class TrackingDetail
    {
        /// <summary>
        /// 추적 시간
        /// </summary>
        public DateTime transTime { get; set; }
        /// <summary>
        /// 레벨
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// 트래킹 장소
        /// </summary>
        public string rtansWhere { get; set; }
        /// <summary>
        /// 트래킹 코드
        /// </summary>
        public string transCode { get; set; }
        /// <summary>
        /// 트래킹 종류
        /// </summary>
        public string transKind { get; set; }
    }

    /// <summary>
    /// 이용자
    /// </summary>
    public class User
    {
        /// <summary>
        /// 반품 주소
        /// </summary>
        public string baseAddress { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public string name {get;set;}
        /// <summary>
        /// 자세한 주소 (마킹처리)
        /// </summary>
        public string detailAddress {get;set;}
        /// <summary>
        /// 전화번호 (마킹처리)
        /// </summary>
        public string tel {get;set;}
        /// <summary>
        /// 운반타입
        /// </summary>
        public string carrierName {get;set;}
    }
}