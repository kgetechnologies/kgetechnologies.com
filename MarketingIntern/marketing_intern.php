

<?php   
   
   include('includes/db_config.php');

  
     
    $message=$fullname=$phone=$email=$degree=$year=$college='';

    $errors=array('fullname'=>'','phone'=>'','email'=>'','degree'=>'','year'=>'','college'=>'','radio'=>'','date'=>'');
    if(isset($_POST['submit'])){

	  $email=$_POST['email'];
	    if(empty($email)){
	      $errors['email']='email is required';
	    }

   
      $fullname=$_POST['fullname'];
      if(empty($fullname)){
        $errors['fullname']='name is required';
      }else if(!preg_match('/^[a-zA-Z\s]+$/', $fullname)){
        $errors['fullname']='name contain letters only';
      }
      
      $phone=$_POST['phone'];
      if(empty($phone)){
        $errors['phone']='phone is required';
      }else if(!preg_match('/^[6-9][0-9]{9}$/', $phone)){
        $errors['phone']='phone contain numbers only';
      }
      
 
      $year=$_POST['year'];
      if(empty($year)){
        $errors['year']='year is required';
      }

      
      $degree=$_POST['degree'];
      if(empty($degree)){
        $errors['degree']='degree is required';
      }else if(!preg_match('/^[a-zA-Z\s]+$/', $degree)){
        $errors['degree']='degree contain letters only';
      }
      $college=$_POST['college'];
      $captcha=$_POST['g-recaptcha-response'];
      if(empty($_POST['radio'])){
      	$errors['radio']='You must answer this';
      }else{
      	$laptop_availabality=$_POST['radio'];
      }
      if(empty($_POST['date'])){
      	$errors['date']='date is required';
      }else{
      	
      	$date=date('Y-m-d', strtotime($_POST['date']));
      }

      if(array_filter($errors)){

      }else{
        if(!$captcha){
          $message='please check the captcha';
        }
        $secretKey = "6LdBu0QcAAAAANFuFVptIEyk9aZtPWgb5L6x3tD0";
        $ip = $_SERVER['REMOTE_ADDR'];
        $url = 'https://www.google.com/recaptcha/api/siteverify?secret=' . urlencode($secretKey) .  '&response=' . urlencode($captcha);
        $response = file_get_contents($url);
        $responseKeys = json_decode($response,true);

        if($responseKeys["success"]) {
               

              $data=[
               'email'=>$email,
               'fullname'=>$fullname,
               'phone'=>$phone,
               'degree'=>$degree,
               'year'=>$year,
               'college'=>$college,
               'Tentative start date'=>$date,
               'laptop_availabality'=>$laptop_availabality
               
              ];

              

              $ref_c= 'candidate_detail/';

              $postdata=$database->getReference($ref_c)->push($data);

              if($postdata){
                $message="submitted succesfull";
              }else{
                 $message="error";
              }
    }else{
    	$message='some error';
    }
   }
 }
?>



<?php include('MainHeader.php') ?>
<div class="form-body">
        <div class="row">
            <div class="form-holder">
                <div class="form-content">
                    <div class="form-items">
               <!-- <div class="row p-3 mb-2 bg-primary text-white" style="margin-top: 5%;padding-top: 2%;">-->
                	<div ><?php echo $message; ?> </div>
                	<h3>Marketing Internship Enrollment</h3>
	<form action="marketing_intern.php" method="POST" >
		<!--<div class="col-lg-10">-->
    
    <label for="email">Email :</label>
    <input type="email"  name="email" value="<?php echo htmlspecialchars($email) ?>" class="form-control" id="email">
    <p class="text-warning"><?php echo $errors['email']; ?></p>
 
  	
    <label for="fullname">Full Name</label>
    <input type="text"   name="fullname" value="<?php echo htmlspecialchars($fullname) ?>" class="form-control" id="fullname">
     <p class="text-warning"><?php echo $errors['fullname']; ?></p>

  	
    <label for="ph">Phone Number</label>
    <input type="text"  name="phone" value="<?php echo htmlspecialchars($phone) ?>" class="form-control" id="ph">
     <p class="text-warning"><?php echo $errors['phone']; ?></p>
  	
    <label for="degree">Current degree & Department</label>
    <input type="text"  name="degree" value="<?php echo htmlspecialchars($degree) ?>" class="form-control" id="degree">
     <p class="text-warning"><?php echo $errors['degree']; ?></p>

    <label for="year">Year of study</label>
    <input type="text" style="width: 30%;" name="year" value="<?php echo htmlspecialchars($year) ?>" class="form-control" id="year">
     <p class="text-warning"><?php echo $errors['year']; ?></p>
 
  	
    <label for="adr">College Name & Address</label>
    <input type="text" style="width: 30%;" name="college" value="<?php echo htmlspecialchars($college) ?>" class="form-control" id="adr">
     <p class="text-warning"><?php echo $errors['college']; ?></p>

    <label for="date">Internship date</label>
    <input type="date" name="date"  name="date" class="form-control" id="date">
     <p class="text-warning"><?php echo $errors['date']; ?></p>

   

    <label>Do you have laptop with internet connectivity?</label>
<div class="custom-control custom-radio">
    <input name="radio" type="radio" value="yes" id="yes">
    <label for="yes">yes</label> 
</div>
    <div class="custom-control custom-radio">
     <input name="radio" type="radio" value="no" id="no">
    <label for="no">No</label> 
  </div>
   <p class="text-warning"><?php echo $errors['radio']; ?></p>
   <div class="g-recaptcha" data-sitekey="6LdBu0QcAAAAAIpkyJr6XImgU8BDmTn6oDUBbavw"></div>
  <button type="submit" name='submit' class="btn btn-default">Submit</button>
    
</form>
</div>
</div>
</div>
</div>
</div>