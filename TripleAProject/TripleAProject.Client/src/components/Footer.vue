

<template>
  <footer class="text-center text-white" style="background-color: #b275d1">
    <div class="container-fluid pt-4">
      <section class="mb-4">
        <a
          class="btn btn-link btn-floating btn-lg text-white m-1"
          href="https://twitter.com/TripleA_Projekt"
          target="_blank"
          role="button"
          data-mdb-ripple-color="white"
          ><font-awesome-icon icon="fa-brands fa-twitter"
        /></a>
        <a
          class="btn btn-link btn-floating btn-lg text-white m-1"
          href="https://www.facebook.com/profile.php?id=100089266395491"
          role="button"
          data-mdb-ripple-color="white"
          target="_blank"
        >
          <font-awesome-icon icon="fab fa-facebook-f"
        /></a>

        <a
          class="btn btn-link btn-floating btn-lg text-white m-1"
          href="https://www.instagram.com/triplea_projekt/"
          target="_blank"
          role="button"
          data-mdb-ripple-color="white"
          ><font-awesome-icon icon="fa-brands fa-instagram"
        /></a>
      </section>

      <section class="">
        <div class="container-fluid text-center text-whitetext-md-start mt-5">
          <div class="row mt-3">
            <div class="col-md-3 col-lg-4 col-xl-3 mx-auto mb-4">
              <h6 class="text-uppercase fw-bold mb-4">
                <i class="fas fa-tshirt me-3"></i>Triple A
              </h6>
              <p>
                Wir sind eine Streaming-Webseite, wo ihr kostenfrei Filme und
                Serien anschauen könnt.
              </p>
            </div>
            <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">
              <h6 class="text-uppercase fw-bold mb-4">Genre</h6>
              <p>
                <a href="#" class="text-reset">Filme</a>
              </p>
              <p>
                <a href="#" class="text-reset">Serien</a>
              </p>
            </div>
            <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">
              <h6 class="text-uppercase fw-bold mb-4">Hilfe</h6>
               <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">
                <router-link to="/impressum">
                  <a class="text-reset">Impressum</a>
                </router-link>
              </div>

              <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">
                <router-link to="/aboutYou">
                  <a class="text-reset">AboutMe</a>
                </router-link>
              </div>
            </div>
            <div class="col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4">
              <h6 class="text-uppercase fw-bold mb-4">Kontakt</h6>
              <p>
                <i class="fas fa-home me-3"></i> 1050 Wien, Spengergasse 20, AUT
              </p>
              <p>
                <i class="fas fa-envelope me-3"></i>
                tripleaprojekt@gmail.com
              </p>
              <p><i class="fas fa-phone me-3"></i>+43 1 54615 0</p>
              <p><i class="fas fa-print me-3"></i>+43 1 54615 139</p>
            </div>
          </div>
        </div>
      </section>
    </div>
    <div
      class="text-center text-white p-3"
      style="background-color: rgba(0, 0, 0, 0.2)"
    >
      © 2023 Copyright:
      <a class="text-white" href="#">TripleA</a>
    </div>
  </footer>
</template>


<style scoped>

a{

  color: white;
}
</style>