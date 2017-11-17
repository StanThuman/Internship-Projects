var mongoose = require('mongoose');
var Schema = mongoose.Schema;
var faker = require('faker');

var ProfileSchema = new Schema({
  username: String,
  google: {
    id: String,
    token: String,
    email: String,
    name: String
  },
  firstName: String,
  lastName: String,
  email: String,
  age: Number,
  height: String,
  birthDate: String,
  Address: String,
  currentWeight: Number,
  goalWeight: Number,
  calorieGoal: Number,
  // posts: [{type: Schema.ObjectId, ref: 'posts'}],
  // workout: [{type: Schema.ObjectId, ref: 'Workout'}],
  // diet: [{type: Schema.ObjectId, ref: 'Diet'}]
});

//this creates the model for use in our application
var Profile = mongoose.model('userprofiles', ProfileSchema);

module.exports = Profile;
