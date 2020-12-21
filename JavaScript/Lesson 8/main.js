// fetch(
//     'https://jsonplaceholder.typicode.com/posts',
//     {
//         method: 'POST',
//         body: JSON.stringify({
//             userId: 1,
//             title: "IT STEP",
//             body: "Lorem ipsum dolor sit amet."
//         }),
//         headers: {
//            'Content-type': 'application/json'
//         }
//     }
// )
// .then(
//     response => {
//         return response.json();
//     }
// )
// .then(
//     json => {
//         console.log(json);
//     }
// )
// .catch(
//     error => {
//         console.log("SERVER ERROR: ", error);
//     }
// )


// fetch('https://jsonplaceholder.typicode.com/posts/13', {
//     method: 'DELETE'
// })
//     .then(
//         response => {
//             if(response.status == 200) {
//                 alert("Post removed!")
//             } else {
//                 alert("SERVER ERROR!")
//             }
//         }
//     )
//     .catch(
//         error => {
//             console.log("SERVER ERROR: ", error);
//         }
//     )



fetch(
    'https://jsonplaceholder.typicode.com/posts/23',
    {
        method: 'PUT',
        body: JSON.stringify({
            id: 23,
            userId: 1,
            title: "IT STEP",
            body: "Lorem ipsum dolor sit amet."
        }),
        headers: {
            'Content-type': 'application/json'
        }
    }
)
    .then(
        response => {
            if (response.status == 200) {
                alert("Post edited!")
            } else {
                alert("SERVER ERROR!")
            }
        }
    )
    .catch(
        error => {
            console.log("SERVER ERROR: ", error);
        }
    )