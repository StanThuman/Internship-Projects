var mongoose = require('mongoose');
var Schema = mongoose.Schema;
var exerciseSchema = new Schema({
  name: String,
  duration: String,
  type: String,
  weight:String,
  sets: String,
  reps: String
});

var workoutSchema = new Schema({
  author:{ type: Schema.ObjectId, ref:'userprofiles'},
  exercises:[exerciseSchema],
  date: String,
  totalWorkoutDuration: String
});

var Workout = mongoose.model('workouts', workoutSchema);
module.exports = Workout;
