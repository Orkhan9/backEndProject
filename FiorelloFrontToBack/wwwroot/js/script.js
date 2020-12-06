$(document).ready(function() {

    //loadmore
    let skip = 8;
    $(document).on('click', '#loadMore', function () {
        let ProductCount = $("#ProductCount").val();
        $.ajax({
            url:'/Product/Load?skip='+skip,
            type: 'Get',
            success: function (res) {
                $("#productList").append(res)
                skip += 8;
                if (skip >= ProductCount) {
                    $("#loadMore").remove();
                }
            }
        })
    })

    //search
    $(document).on('keyup', '#input-search', function () {
        let searchinput = $("#input-search").val().trim();
        $("#searchList li").slice(1).remove();
        if (searchinput.length > 0) {
            $.ajax({
                url: '/Product/Search?search=' + searchinput,
                type: 'Get',
                success: function (res) {
                    $("#searchList").append(res);

                }
            })
        }
    })

    //addbasket
    let allAddSpan = document.querySelectorAll(".addToBasket")
    allAddSpan.forEach(item => {
        item.addEventListener("click", function () {
                event.preventDefault();
                let id = $(this).attr("data-id");
                $.ajax({
                    url: "/Basket/AddBasket?Id=" + id,
                    type: "Get",
                    success: function (res) {
                        console.log(res)
                        let totalPriceNav = document.getElementById('totalPriceNav');
                        let totalCountNav = document.getElementById('totalCountNav');
                        totalPriceNav.innerHTML = 'CART (' + res.basketTotalPrice + ')';
                        totalCountNav.innerHTML = res.basketProductCount;
                    }
                })
        })
    })

    //remove product from basket
    let allRemove = document.querySelectorAll(".removeProduct")
    allRemove.forEach(item => {
        item.addEventListener("click", function () {
            event.preventDefault();
            let id = $(this).attr("data-id");
            $.ajax({
                url: "/Basket/RemoveProduct?Id=" + id,
                type: "Get",
                success: function (res) {
                    let basketTotalPrice = document.getElementById('basketTotalPrice');
                    let totalPriceNav = document.getElementById('totalPriceNav');
                    let totalCountNav = document.getElementById('totalCountNav');
                    basketTotalPrice.innerHTML = 'Total:' + res.basketTotalPrice;
                    totalPriceNav.innerHTML = 'CART' + ' (' + res.basketTotalPrice + ')';
                    totalCountNav.innerHTML = res.basketProductCount;
                    item.parentElement.parentElement.parentElement.remove();
                }
            })
        })
    })

    // HEADER

    $(document).on('click', '#search', function() {
        $(this).next().toggle();
    })

    $(document).on('click', '#mobile-navbar-close', function() {
        $(this).parent().removeClass("active");

    })
    $(document).on('click', '#mobile-navbar-show', function() {
        $('.mobile-navbar').addClass("active");

    })

    $(document).on('click', '.mobile-navbar ul li a', function() {
        if ($(this).children('i').hasClass('fa-caret-right')) {
            $(this).children('i').removeClass('fa-caret-right').addClass('fa-sort-down')
        } else {
            $(this).children('i').removeClass('fa-sort-down').addClass('fa-caret-right')
        }
        $(this).parent().next().slideToggle();
    })

    // SLIDER

    $(document).ready(function() {
        $(".slider").owlCarousel({
            items: 1,
            loop: true,
            autoplay: true
        });
    });

    // PRODUCT

    $(document).on('click', '.categories', function(e) {
        e.preventDefault();
        $(this).next().next().slideToggle();
    })

    $(document).on('click', '.category li a', function(e) {
        e.preventDefault();
        let category = $(this).attr('data-id');
        let products = $('.product-item');

        products.each(function() {
            if (category == $(this).attr('data-id')) {
                $(this).parent().fadeIn();
            } else {
                $(this).parent().hide();
            }
        })
        if (category == 'all') {
            products.parent().fadeIn();
        }
    })

    // ACCORDION 

    $(document).on('click', '.question', function() {
        $(this).siblings('.question').children('i').removeClass('fa-minus').addClass('fa-plus');
        $(this).siblings('.answer').not($(this).next()).slideUp();
        $(this).children('i').toggleClass('fa-plus').toggleClass('fa-minus');
        $(this).next().slideToggle();
        $(this).siblings('.active').removeClass('active');
        $(this).toggleClass('active');
    })

    // TAB

    $(document).on('click', 'ul li', function() {
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().next().children('p.active').removeClass('active');

        $(this).parent().next().children('p').each(function() {
            if (dataId == $(this).attr('data-id')) {
                $(this).addClass('active')
            }
        })
    })

    $(document).on('click', '.tab4 ul li', function() {
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().parent().next().children().children('p.active').removeClass('active');

        $(this).parent().parent().next().children().children('p').each(function() {
            if (dataId == $(this).attr('data-id')) {
                $(this).addClass('active')
            }
        })
    })

    // INSTAGRAM

    $(document).ready(function() {
        $(".instagram").owlCarousel({
            items: 4,
            loop: true,
            autoplay: true,
            responsive: {
                0: {
                    items: 1
                },
                576: {
                    items: 2
                },
                768: {
                    items: 3
                },
                992: {
                    items: 4
                }
            }
        });
    });

    $(document).ready(function() {
        $(".say").owlCarousel({
            items: 1,
            loop: true,
            autoplay: true
        });
    });




    $(window).load(function() {
        // Animate loader off screen
        $(".se-pre-con").slideUp(3000);
    });



})