var posts = [];
var users = [];

fetch('https://jsonplaceholder.typicode.com/posts')
    .then(
        response => {
            if(response.status == 200) {
                return response.json();
            }
            else {
                console.log("ERROR")
            }
        }
    )
    .then(
        json => {
            posts = json;
            for(var i = 0; i < 10; i++) {
                $("#listPosts").append(
                    `
                <div class="card col-lg-6 col-md-6 col-sm-12 col-12" >
                    <div class="card-body">
                      <h5 class="card-title" >${posts[i].title}</h5>
                      <p class="card-text">${posts[i].body}</p>
                      <a href="#" class="card-link">More info</a>
                    </div>
                </div>
                    `
                );
            }
        }
    )
    .catch(
        error => {
            console.log(error);
        }
    )


fetch('https://jsonplaceholder.typicode.com/users')
        .then(
            response => {
                if(response.status == 200) {
                    return response.json();
                }
                else {
                    console.log("ERROR")
                }
            }
        )
        .then(
            json => {
                users = json;
                for(var i = 0; i < 10; i++) {
                    $("#listUsers").append(
                        `
                    <div class="card col-lg-3 col-md-3 col-sm-6 col-12" >
                        <div class="card-body">
                          <img style="width: 100%;" src="https://secure.gravatar.com/avatar/ec67e4417439c9ca226ec53d4014fd9c?s=150&r=g&d=https://www.russianwithmax.com/wp-content/plugins/userswp/assets/images/no_profile.png" alt="">
                          <h5 class="card-title">${users[i].name}</h5>
                          <p class="card-text">${users[i].phone}</p>
                          <a href="#" class="card-link">More info</a>
                        </div>
                    </div>
                        `
                    );
                }
            }
        )
        .catch(
            error => {
                console.log(error);
            }
        )
