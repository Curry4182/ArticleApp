﻿ using Dul.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ArticleApp.Models
{
    /// <summary>
    /// 게시판(Article) 모델 클래스: Articles 테이블 일대일로 매핑 
    /// </summary>
    public class Article : AuditableBase
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 제목
        /// </summary>
        [Required(ErrorMessage = "제목을 입력하세요")]
        public string Title { get; set; }

        /// <summary>
        /// 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력하세요.")]
        public string Content { get; set; }

        /// <summary>
        /// 공지글인가? 
        /// </summary>
        public bool IsPinned { get; set; } = false;
    }
}
