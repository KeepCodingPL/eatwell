package com.keepcodingpl.eatwell.mypostsfragment.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.keepcodingpl.eatwell.databinding.PostItemRowBinding
import com.keepcodingpl.eatwell.model.Post

class MyPostAdapter(private val postList: ArrayList<Post>) :
    RecyclerView.Adapter<MyPostAdapter.MyPostViewHolder>() {

     val list =
        mutableListOf(
            postList.add(Post("Köfte", "Helal")),
            postList.add(Post("Salata", "Helal"))
        )

    class MyPostViewHolder(val binding: PostItemRowBinding) : RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyPostViewHolder {
        val binding = PostItemRowBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return MyPostViewHolder(binding)
    }

    override fun onBindViewHolder(holder: MyPostViewHolder, position: Int) {
        holder.binding.post = postList[position]
    }

    fun deleteItem(index: Int) {
        postList.removeAt(index)
        notifyDataSetChanged()
    }

    override fun getItemCount() = postList.size
}