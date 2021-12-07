package com.keepcodingpl.eatwell.mypostsfragment

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.AsyncListDiffer
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.RecyclerView
import com.keepcodingpl.eatwell.databinding.PostItemRowBinding
import com.keepcodingpl.eatwell.model.Post

class MyPostAdapter :
    RecyclerView.Adapter<MyPostAdapter.MyPostViewHolder>() {
    // list = dummy data. You can delete

    inner class MyPostViewHolder(val binding: PostItemRowBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(post: Post) {
            binding.apply {
                postMealName.text = post.postName
                postMealCategory.text = post.postCategory
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyPostViewHolder {
        val binding = PostItemRowBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return MyPostViewHolder(binding)
    }

    override fun onBindViewHolder(holder: MyPostViewHolder, position: Int) {
        val postList = posts[position]
        holder.bind(postList)
    }

    private val diffUtil = object : DiffUtil.ItemCallback<Post>() {
        override fun areItemsTheSame(oldItem: Post, newItem: Post): Boolean {
            return oldItem == newItem
        }

        override fun areContentsTheSame(oldItem: Post, newItem: Post): Boolean {
            return oldItem == newItem
        }
    }

    private val recyclerListDiffer = AsyncListDiffer(this, diffUtil)

    var posts: List<Post>
        get() = recyclerListDiffer.currentList
        set(value) = recyclerListDiffer.submitList(value)

    fun deleteElement(position: Int) {
        recyclerListDiffer.currentList.removeAt(position)
        notifyDataSetChanged()
    }

    override fun getItemCount() = posts.size
}