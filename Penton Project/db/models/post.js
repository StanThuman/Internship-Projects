var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var postSchema = new Schema({
  author: {type: Schema.ObjectId, ref:'userprofiles'},
  postTitle: {
    type: String,
    required: true,
  },
  postMessage: String,
  datePosted: String,
  likes:Number,
  dislikes: Number,
  comments: [{
    username: String,
    postTitle: String,
    postMessage: String,
    datePosted: String,
    likes:Number,
    dislikes: Number,
  }]
});

var Post = mongoose.model('posts', postSchema);


module.exports = Post;
