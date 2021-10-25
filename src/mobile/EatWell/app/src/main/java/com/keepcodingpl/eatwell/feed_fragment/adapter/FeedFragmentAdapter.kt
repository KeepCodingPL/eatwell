package com.keepcodingpl.eatwell.feed_fragment.adapter

import android.annotation.SuppressLint
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.keepcodingpl.eatwell.databinding.ItemMealBinding
import com.keepcodingpl.eatwell.model.Meal

class FeedFragmentAdapter(private val mealList: ArrayList<Meal>) :
    RecyclerView.Adapter<FeedFragmentAdapter.MyViewHolder>() {

    inner class MyViewHolder(val binding: ItemMealBinding) : RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyViewHolder {
        val binding = ItemMealBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return MyViewHolder(binding)
    }

    override fun onBindViewHolder(holder: MyViewHolder, position: Int) {
        holder.binding.meal = mealList[position]
    }

    override fun getItemCount() = mealList.size

    @SuppressLint("NotifyDataSetChanged")
    fun updateList(newMealList: List<Meal>) {
        mealList.clear()
        mealList.addAll(newMealList)
        notifyDataSetChanged()
    }

}