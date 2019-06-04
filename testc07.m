clear all
clc
seed=1;
yc3out=zeros(20,1000);
am_arr=rand(20,1)+0.1;
wid_arr=randi([8,64],20,1);
delay_arr=randi([20,900],20,1);
seed_arr=randi([1,1000],20,1);
for i=1:20
    amplitude=am_arr(i,1);
    widthp=wid_arr(i,1);
    delay=delay_arr(i,1);
    seed=seed_arr(i,1);
    sim("testc7.slx");
    yc3out(i,:)=yc3;
end
stairs(tout,yc3out')
save y3c.mat yc3out;