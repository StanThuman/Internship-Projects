var faker = require('faker');
var Profile = require('./models/profile')
var profile1 = {
  firstName: faker.name.firstName(),
  lastName: faker.name.lastName(),
  age: faker.random.number(),
  height: faker.random.number(),
  birthDate: faker.date.recent(),
  Address: faker.address.streetAddress(),
  currentWeight: faker.random.number(),
  goalWeight: faker.random.number(),
  calorieGoal: faker.random.number(),
}
function createProfile(){
  return new Profile({
    google: {
      id: '113378028470117412506',
      token: '',
      email: 'stanley.lim@ruralsourcing.com',
      name: 'test'
    },
    firstName: faker.name.firstName(),
    lastName: faker.name.lastName(),
    age: faker.random.number(),
    height: faker.random.number(),
    birthDate: faker.date.recent(),
    address: faker.address.streetAddress(),
    currentWeight: faker.random.number(),
    goalWeight:(( Math.random()*100) + 100),
    calorieGoal: (( Math.random()*1000) + 100),
    posts: [{
      username: faker.name.firstName(),
      postTitle: faker.lorem.sentence(),
      postMessage: faker.lorem.sentences(),
      datePosted: faker.date.recent(),
      likes: (Math.random()*10),
      dislikes: (Math.random()*10),
      comments: [{
        username: faker.name.firstName(),
        postTitle: faker.lorem.sentence(),
        postMessage: faker.lorem.sentences(),
        datePosted: faker.date.recent(),
        likes: (Math.random()*10),
        dislikes: (Math.random()*10)
      }]
    }]//,
  //   workout:[{
  //     exercises:[{
  //       name: faker.internet.color(),
  //       duration: Math.round(Math.random()*100),
  //       type: faker.name.jobType()
  //     }],
  //   date: faker.date.recent(),
  //   totalWorkoutDuration: Math.round(Math.random()*1000)
  // }],
  // diet:[{
  //   totalCalories: Math.round(Math.random()*10000),
  //   date: faker.date.recent(),
  //   food: [{
  //     foodName: faker.name.title(),
  //     foodType: faker.name.jobType(),
  //     calories: Math.round(Math.random()*10000),
  //   }]
  //}]
  });
}

module.exports = createProfile;
