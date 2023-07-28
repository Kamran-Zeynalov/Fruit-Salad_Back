$(document).ready(function () {
  $(".title-categories .title").on("click", function () {
    $("div.categories").slideToggle();
     $("div.season").slideUp();
    $(".title-calori .calories").slideUp();
    $(".title-taste .taste").slideUp();
  });
  $(".title-categories .categories .fruit-categories").on("click", function () {
    $(this).next().slideToggle();
    $(this).parent().find(".fruit-categories").not(this).next().slideUp();

  });

  $(".title-calori .title").on("click", function () {
    $(".title-calori .calories").slideToggle();
    $(".title-taste .taste").slideUp();
    $("div.categories").slideUp();
    $("div.season").slideUp();

  });
  $(".title-taste .title").on("click", function () {
    $(".title-taste .taste").slideToggle();
    $(".title-calori .calories").slideUp();
    $("div.categories").slideUp();
    $("div.season").slideUp();

  });

  $(".title-season .title").on("click", function () {
    $("div.season").slideToggle();
    $("div.categories").slideUp();
    $(".title-calori .calories").slideUp();
    $(".title-taste .taste").slideUp();
  });
   $(".title-season .season .fruit-season").on("click", function () {
    $(this).next().slideToggle();
    $(this).parent().find(".fruit-season").not(this).next().slideUp();
  });
});
