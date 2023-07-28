<?php
  require '_dbcon.php';

  if(isset($_POST['add_to_cart'])){

    // $product_image = $_POST['image'];
    $product_name = $_POST['name'];
    $product_brand = $_POST['brand'];
    $product_price = $_POST['price'];
    $product_quantity = 1;
 
    $select_cart = mysqli_query($connect, "SELECT * FROM `cart` WHERE name = '$product_name'");
 
    if(mysqli_num_rows($select_cart) > 0){
       $message[] = 'product already added to cart';
    }
    else{
       $insert_product = mysqli_query($connect, "INSERT INTO `cart`( name, brand, price, quantity) VALUES( '$product_name', '$product_brand', '$product_price', '$product_quantity')");
       $message[] = 'product added to cart succesfully';
    }
 
 }
?>


<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>online shopping site for makeup</title>
    <link href="styledashboard.css" rel="stylesheet">
    <link rel="icon" href="logo.png" type="x-icon">
    <script src="https://kit.fontawesome.com/75a3d09ada.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css2?family=Abril+Fatface&family=Caprasimo&family=Roboto:wght@300&display=swap" rel="stylesheet">
    
   
</head>

<body>
    <!--Header section-->
    <header>
        
        <div class="img">
            <img src="logo.png" height="36px" width="45px" alt="">
        </div>

        <div class="header-left">   
            <a href="#">GLAMOASIS</a>
            <div class="header-left-p">
                <P>
                    <a href="#">Unlock Your Inner Glow   
                    </a>
                </P>
            </div>
        </div>
     
        <!-- <form action="search.php" method="GET"> -->
        <div class="header-center" >
          <input class="header-center-input" name="searchTerm" type="search" placeholder="search for products"><i class="fa-solid fa-magnifying-glass"></i>
        </div>   
        <!-- </form> -->

        <!----------cart----------->
        <span class="cart-lan">
            <a href="cart.php"> <i class="fa-solid fa-cart-shopping"></i></a>cart
        </span>
    </header>

    <!----------category section------------>
    <section>
        <div class="category-row">
            <div class="category-col">
                <img src="offer.jpg"  alt="">
                <h5>Top Offers</h5>
            </div>
            <div class="category-col">
                <img src="makeup.jpg"  alt="">
                <h5>Make Up</h5>
            </div>
            <div class="category-col">
                <img src="skincare.jpg" alt="" >
                <h5>Skin Care</h5>
            </div>
            <div class="category-col">
                <img src="haircare.jpg" alt="">
                <h5>Hair Care</h5>
            </div>
            <div class="category-col">
                <img src="makeuptools.jpg" alt="">
                <h5>MakeUp Tools</h5>
            </div>
            <div class="category-col">
                <img src="hairtools.png" alt="">
                <h5>Hair Tools</h5>
            </div>
            <div class="category-col">
                <img src="electronics.jpg"  alt="">
                <h5>Electronics</h5>
            </div>
        </div>
    </section>

    <!-----------------banner section-------------------->
    <section>
        <div class="banner">
            <div class="slider">
                <img src="banner1.jpg" alt="banner" width="20%">
                <img src="banner2.jpg" alt="banner" width="20%"> 
                <img src="banner3.jpg" alt="banner" width="20%">
                <img src="banner4.png" alt="banner" width="20%"> 
                <img src="banner5.jpg" alt="banner" width="20%">
                <img src="banner6.jpg" alt="banner" width="20%"> 
            </div>
        </div>
    </section>

<section>


    <div class="container">
    
        <div class="row ">
        <?php

            $sql1 = "SELECT * FROM `product`";
            $sqlres = mysqli_query($connect, $sql1); 
            while($row = mysqli_fetch_assoc($sqlres)) {
            // echo $row['product-ID'] ." ". $row['product-name'] ." ". $row['product-brand'] ." ". $row['product-price'] ." ". $row['image']."<br>";

        ?>

        <form action="" method="post" >

         <div  class="product">
           
            <div class="product-img">
            <img src="<?php echo $row['image']?>" alt=""  width="200px" height="200px">
            </div>

            <h3 class="product-name"><?php echo $row['product-name']?></h3>
            <h3 class="product-brand"><?php echo $row['product-brand']?></h3>

            <h4 class="product-price">Price: <?php echo $row['product-price']?></h4>

            <div class="form-group">
            <!-- <select class="form-control" id="quantity<?php echo $row['product-ID']?>"  -->
            
             <!-- <select class="form-control" id="quantity" >
            <option>1</option>            
            <option>2</option>
            <option>3</option>
            <option>4</option>
            <option>5</option>
            <option>6</option>
            <option>7</option>
            <option>8</option>
            <option>9</option>
            <option>10</option>
            </select><br> -->
            <input type="hidden" name="image" id="image<?php echo $row['product-ID']?>" value='<?php echo $row['product-img']?>'>
            <input type="hidden" name="name" id="name<?php echo $row['product-ID']?>" value='<?php echo $row['product-name']?>'>
            <input type="hidden" name="brand" id="brand<?php echo $row['product-ID']?>" value='<?php echo $row['product-brand']?>'>
            <input type="hidden" name="price" id="price<?php echo $row['product-ID']?>" value='<?php echo $row['product-price']?>'>
            <!-- <button class='btn btn-danger add'  data-id="<?php echo $row['product-ID']?>" >Add to Cart</button> -->

              <button class='btn btn-danger add' name="add_to_cart">Add to Cart</button>
              <!-- <input type="submit" class="btn" value="add to cart" name="add_to_cart"> -->
            
            </div>

        </div>

        </form>
        
     <?php
         }
     ?>
        </div>
        
    </div>
</section>







    <!-- <section>
        <div class="All-products">
            <div class="product">
                <div class="product-img">
                    <img src="product1.jpg" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">liquid foundation<br>Huda Beauty </h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:2500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a> 
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a> 
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product2.jpeg" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">foundation stick<br>Huda Beauty</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:4000</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product3.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">primer<br>Huda Beauty</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:1800</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>


            <div class="product">
            <div class="product-img">
                <img src="product4.jpg" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">pink tint<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:400</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product5.jpg" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">loose powder<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:2000</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product6.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">lipstick<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:300</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product7.jpg" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">mascara<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:1000</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product8.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">eye pallete<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:1200</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product9.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">lip shades deal<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:1500</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product10.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">foundation brush<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:300</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product11.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">makeup brushes<br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:800</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product12.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">face powder <br>Huda Beauty</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:1200</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product13.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">Hydera Facial kit<br>IQ organics</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:7500</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product14.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">lip care kit<br> IQ organics</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:4000</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
            <div class="product-img">
                <img src="product15.webp" alt="" width="200px" height="200px">
            </div>
            <h4 class="product-name">Coffee face wash<br>IQ organics</h4>
            <p class="product-price">
                <i class="fa-sharp fa-solid fa-rupee-sign">:1400</i>
            </p>
            <div class="stepper-input">
                <a href="#" class="decrement">-</a>
                <input type="number" class="quantity" value="1">
                <a href="#" class="increment">+</a>
            </div>
            <div class="product-action">
                <button class type="button">ADD TO CART</button>
            </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product16.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Acne treatment bundle<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:6800</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product17.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">pigmentation treatment<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:6950</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>


            <div class="product">
                <div class="product-img">
                    <img src="product18.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Freshening Alovera Soothing Mist<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:1200</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product19.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">skin brightening powder<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:1200</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product20.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">hair serum & coccunet oil<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:2800</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product21.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">brightening serum<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:1500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product22.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Eyelash curler<br>Twezerman</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:1200</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product23.jpg" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Set Of 5 Pcs Braid Tools</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:300</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product24.jpg" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Best Hair Styling Comb and Clips</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product25.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair Tonic<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:2200</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product26.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair Care Bundle<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:6000</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product27.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">skincare bundle<br>IQ organics</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:7100</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product28.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair Straightner<br>Remington</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:9500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product29.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair Dryer<br>Remington</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:10500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product30.jpg" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair curler<br>Remington</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:9000</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product31.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair waver<br>Remington</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:11500</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>

            <div class="product">
                <div class="product-img">
                    <img src="product32.webp" alt="" width="200px" height="200px">
                </div>
                <h4 class="product-name">Hair crimper<br>Remington</h4>
                <p class="product-price">
                    <i class="fa-sharp fa-solid fa-rupee-sign">:12000</i>
                </p>
                <div class="stepper-input">
                    <a href="#" class="decrement">-</a>
                    <input type="number" class="quantity" value="1">
                    <a href="#" class="increment">+</a>
                </div>
                <div class="product-action">
                    <button class type="button">ADD TO CART</button>
                </div>
            </div>
        </div>
    </section> -->

    <footer>
        <p>
            © 2023
            <strong>GLAMOASIS</strong>
            "- buy makeup and beauty products online" 
        </p>
    </footer>
</body>
</html>