import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

import { library } from '@fortawesome/fontawesome-svg-core'

import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'


import { faFacebookF, faInstagram, faTwitter } from '@fortawesome/free-brands-svg-icons'

const app = createApp(App)
library.add(faInstagram, faTwitter, faFacebookF)
app.use(router)
.component('font-awesome-icon', FontAwesomeIcon,'faInstagram', faInstagram,'faTwitter', faTwitter,'faFacebookF', faFacebookF)
app.mount('#app')
