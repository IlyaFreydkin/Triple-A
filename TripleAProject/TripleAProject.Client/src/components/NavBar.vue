<template>
     <nav id="navbar" class="navbar navbar-expand-lg sticky-top navbar-light ">
  <div class="container-fluid">
    <a class="navbar-brand" href="#"></a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto  mb-lg-0">
        <router-link to="/" >
        <li class="nav-item me-3 ">
          <a class="nav-link active" id="nav-logo-font" aria-current="page" href="#">Triple A</a>
        </li>
        </router-link>
        
        <router-link to="/foryou">
        <li class="nav-item mx-2 pt-2">
          <a class="nav-link active" id="nav-font" aria-current="page" href="#">For You</a>
        </li>
        </router-link>
        

        <li class="nav-item mx-2 pt-2">
          <a class="nav-link active" id="nav-font" aria-current="page" href="#">Wish List</a>
        </li>

    
      </ul>
      <form class="d-flex px-3">

        <ul class="navbar-nav me-3 mb-lg-0">
            <li class="nav-item mx-2 pt-2">
            <a class="nav-link active" id="nav-font" aria-current="page" href="#">My Account</a>
            </li>

            <router-link to="/login">
                <li class="nav-item mx-2 pt-2">
            <button id="login-btn" class="btn btn-outline-light" type="submit">Login / Sign Up</button>
            </li>
            </router-link>
        </ul>

        
      </form>
    </div>
  </div>
</nav>
</template>


<style scoped>
/*#nav-logo {
    width: 50px;
    height: 50px;
} */


#navbar {
    background-image: linear-gradient(to bottom right,#4B279B,#DF99D8);

}

a {
    text-decoration: none;
  
  }

login-btn {
    font-size: 20px;
    font-family: Poppins, sans-serif;
}

#nav-font {
    color: white;
    font-size: 20px;
    font-family: Poppins, sans-serif;
}

#nav-logo-font {
    color: white;
    font-size: 30px;
    font-family: 'Asul', sans-serif;
}


</style>