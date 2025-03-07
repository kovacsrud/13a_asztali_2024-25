import { Component, OnInit } from '@angular/core';
import { NgIf,NgFor } from '@angular/common';
import { Post } from '../../../types/Post';

@Component({
  selector: 'app-posts',
  imports: [NgIf,NgFor],
  templateUrl: './posts.component.html',
  styleUrl: './posts.component.css'
})
export class PostsComponent implements OnInit {

  ngOnInit(): void {
    this.fetchPosts();
  }

  posts:Post[]=[];
  isLoading=false;

  fetchPosts(){
    this.isLoading=true;
    fetch('https://jsonplaceholder.typicode.com/posts/')
    .then(res=>res.json())
    .then(posts=>this.posts=posts)
    .catch(err=>alert(err))
    .finally(()=>this.isLoading=false);
  }

}
