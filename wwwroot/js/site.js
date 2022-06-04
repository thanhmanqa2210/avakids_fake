// big slide
var num = 1;
$(`.list_slide_btn:nth-child(${num})>.item_active_img`).css({
  border: "1px solid #000",
  "box-shadow": "1px 1px 5px rgba(0, 0, 0, .3)",
});
$(".slide_position_pos").text(num);
$(".slide>.prev").click(() => {
  if (num <= 1) {
    num = 1;
  } else {
    num--;
  }
  $(".detail_left_img>div>.img_list").css({
    transform: `translateX(${-(num - 1) * 100}%)`,
  });
  $(".slide_position_pos").text(num);
  $(`.list_slide_btn:nth-child(${num})>.item_active_img`).css({
    border: "1px solid rgb(115, 115, 115)",
    "box-shadow": "1px 1px 5px rgba(0, 0, 0, .3)",
  });
  $(`.list_slide_btn:nth-child(${num + 1})>.item_active_img`).css({
    border: "none",
    "box-shadow": "none",
  });
  $(`.item_active:nth-child(${num + 1})`).css({
    border: "none",
    "box-shadow": "none",
  });
});
$(".slide>.next").click(() => {
  if (num >= parseInt($(".slide_length").text())) {
    num = parseInt($(".slide_length").text());
  } else {
    num++;
  }
  $(".slide_position_pos").text(num);
  $(".detail_left_img>div>.img_list").css({
    transform: `translateX(${-(num - 1) * 100}%)`,
  });
  $(`.list_slide_btn:nth-child(${num})>.item_active_img`).css({
    border: "1px solid rgb(115, 115, 115)",
    "box-shadow": "1px 1px 5px rgba(0, 0, 0, .3)",
  });
  $(`.list_slide_btn:nth-child(${num - 1})>.item_active_img`).css({
    border: "none",
    "box-shadow": "none",
  });
   $(`.item_active:nth-child(${num-1})`).css({
     border: "none",
     "box-shadow": "none",
   });
});
// small slide
for (let index = 0; index <= parseInt($(".slide_length").text()); index++) {
  $(`.item_active:nth-child(${index})`).click(() => {
    num = index;
    $(".slide_position_pos").text(num);
    $(`.item_active:nth-child(${num})`).css({
      border: "1px solid rgb(115, 115, 115)",
      "box-shadow": "1px 1px 5px rgba(0, 0, 0, .3)",
    });
    $(`.list_slide_btn:nth-child(${num})>.item_active_img`).css({
      border: "1px solid rgb(115, 115, 115)",
      "box-shadow": "1px 1px 5px rgba(0, 0, 0, .3)",
    });
    $(".detail_left_img>div>.img_list").css({
      transform: `translateX(${-(num - 1) * 100}%)`,
    });
    $(`.item_active:not(:nth-child(${num}))`).css({
      border: "none",
      "box-shadow": "none",
    });
    $(`.list_slide_btn:not(:nth-child(${num}))>.item_active_img`).css({
      border: "none",
      "box-shadow": "none",
    });
  });
}
